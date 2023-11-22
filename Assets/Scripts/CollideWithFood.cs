using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithFood : MonoBehaviour
{
    public Score scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        scoreScript.IncreaseScoreAndStar();
    }
}
