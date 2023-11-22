using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAnimal : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public float timeToGenerateAnimal = 2f;

    public int animalIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToGenerateAnimal -= Time.deltaTime;

        if(timeToGenerateAnimal < 0)
        {
            if(animalIndex >= animalPrefabs.Length)
            {
                animalIndex = 0;
            }

            Instantiate(animalPrefabs[animalIndex], animalPrefabs[animalIndex].transform.position, animalPrefabs[animalIndex].transform.rotation);
            animalIndex++;
            timeToGenerateAnimal = 2f;
        }
    }
}
