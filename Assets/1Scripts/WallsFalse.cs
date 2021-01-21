using UnityEngine;

public class WallsFalse : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;

    float wallCurrentTime = 0f;
    float wallTime = 43f;

    bool wallDone = false;

    void Start()
    {
        wall1 = GameObject.FindGameObjectWithTag("Wall");
        wall1.SetActive(true);

        wall2 = GameObject.FindGameObjectWithTag("Wall2");
        wall2.SetActive(true);

        wall3 = GameObject.FindGameObjectWithTag("Wall3");
        wall3.SetActive(true);

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
                wall2.SetActive(false);
                wall3.SetActive(false);
                wallDone = true;
            }
        }
    }
}
