using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float movementSpeed = 10f;
    public float xRange = 10f;

    public GameObject foodProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //To Keep player in bounds.
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        //Taking horizontal input.
        horizontalInput = Input.GetAxis("Horizontal");

        //Moving player on x-axis.
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * movementSpeed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch projectile from the player.
            Instantiate(foodProjectilePrefab, transform.position, foodProjectilePrefab.transform.rotation);
        }
    }
}
