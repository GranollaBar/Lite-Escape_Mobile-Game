using UnityEngine;

public class RemoveText16 : MonoBehaviour
{
    private GameObject player;
    private GameObject EndingLights;
    private GameObject text;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EndingLights = GameObject.FindGameObjectWithTag("EndingLights");
        text = GameObject.FindGameObjectWithTag("text");

        if ((PlayerPrefs.GetInt("TextDestoryLevel16") == 1))
        {
            Destroy(player.GetComponent<Level16Text>());
            Destroy(text);
            Destroy(EndingLights.GetComponent<Level16Walls>());
            EndingLights.AddComponent<WallFalse>();
        }
    }
}
