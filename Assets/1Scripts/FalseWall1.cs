using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseWall1 : MonoBehaviour
{
    public GameObject wall1;

    float wallCurrentTime = 0f;
    float wallTime = 1f;

    bool wallDone = false;

    void Start()
    {
        wall1 = GameObject.FindGameObjectWithTag("Wall");
        wall1.SetActive(true);

        wallCurrentTime = wallTime;
    }


    void Update()
    {
        wallCurrentTime -= 1 * Time.deltaTime;

        if (!wallDone)
        {
            if (wallCurrentTime <= 0)
            {
                wall1.SetActive(false);
                wallDone = true;
            }
        }
    }
}
