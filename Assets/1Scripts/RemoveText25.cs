using UnityEngine;

public class RemoveText25 : MonoBehaviour
{
    private GameObject player;
    private GameObject EndingLights;
    private GameObject text;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EndingLights = GameObject.FindGameObjectWithTag("EndingLights");
        text = GameObject.FindGameObjectWithTag("text");

        if ((PlayerPrefs.GetInt("TextDestoryLevel25") == 1))
        {
            Destroy(player.GetComponent<Level5Text>());
            Destroy(text);
            Destroy(EndingLights.GetComponent<Level5Walls>());
            EndingLights.AddComponent<WallFalse>();
        }
    }
}
