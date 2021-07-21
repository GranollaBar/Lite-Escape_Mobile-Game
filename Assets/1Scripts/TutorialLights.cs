using UnityEngine;

public class TutorialLights : MonoBehaviour
{
    public GameObject lights;
    public GameObject wall;
    public GameObject arrowLight;

    float lightsCurrentTime = 0f;
    float wallCurrentTime = 0f;
    float lightsTime = 25f;
    float wallTime = 55f;

    bool startedSounds = false;
    bool wallDone = false;

    void Start()
    {
        lights = GameObject.FindGameObjectWithTag("lights");
        lights.SetActive(false);

        wall = GameObject.FindGameObjectWithTag("Wall");
        wall.SetActive(true);

        arrowLight = GameObject.FindGameObjectWithTag("MainLights");
        arrowLight.SetActive(false);

        lightsCurrentTime = lightsTime;
        wallCurrentTime = wallTime;
    }


    void Update()
    {
        lightsCurrentTime -= 1 * Time.deltaTime;
        wallCurrentTime -= 1 * Time.deltaTime;

        if (!startedSounds)
        {
            if (lightsCurrentTime <= 0)
            {
                FindObjectOfType<AudioManager>().StopPlay("Main Theme");
                FindObjectOfType<AudioManager>().Play("Lights");
                FindObjectOfType<AudioManager>().Play("Scary");
                lights.SetActive(true);
                startedSounds = true;
            }
        }

        if (!wallDone)
        {
            if (wallCurrentTime <= 0)
            {
                FindObjectOfType<AudioManager>().Play("Lights");
                FindObjectOfType<AudioManager>().Play("WallBreak");
                wall.SetActive(false);
                lights.SetActive(false);
                arrowLight.SetActive(true);
                wallDone = true;
            }
        }
    }
}
