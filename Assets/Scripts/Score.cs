using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;
    int star;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScoreAndStar()
    {
        score++;
        if (score % 3 == 0)
        {
            star++;
        }

        print("Score: " + score + "\nStar: " + star);
    }
}
