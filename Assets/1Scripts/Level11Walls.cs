using UnityEngine;

public class Level11Walls : MonoBehaviour
{
    public GameObject wall1;

    float wallCurrentTime = 0f;
    float wallTime = 55f;

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
