using UnityEngine;

public class WallFalse : MonoBehaviour
{
    private GameObject wall1;

    float wallCurrentTime = 0f;
    float wallTime = 2f;

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
                FindObjectOfType<AudioManager>().Play("WallBreak");
            }
        }
    }
}
