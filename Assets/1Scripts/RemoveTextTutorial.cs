using UnityEngine;

public class RemoveTextTutorial : MonoBehaviour
{
    private GameObject player;
    private GameObject EndingLights;
    private GameObject text;
    private GameObject SecondLights;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EndingLights = GameObject.FindGameObjectWithTag("EndingLights");
        text = GameObject.FindGameObjectWithTag("text");
        SecondLights = GameObject.FindGameObjectWithTag("SecondLight");
        SecondLights.SetActive(false);

        if ((PlayerPrefs.GetInt("TextDestoryTutorial") == 1))
        {
            Destroy(player.GetComponent<Level16Text>());
            Destroy(text);
            Destroy(EndingLights.GetComponent<TutorialLights>());
            EndingLights.AddComponent<WallFalse>();
            SecondLights.SetActive(true);
        }
    }
}
