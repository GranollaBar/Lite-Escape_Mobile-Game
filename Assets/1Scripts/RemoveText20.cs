using UnityEngine;

public class RemoveText20 : MonoBehaviour
{
    private GameObject player;
    private GameObject EndingLights;
    private GameObject text;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EndingLights = GameObject.FindGameObjectWithTag("EndingLights");
        text = GameObject.FindGameObjectWithTag("text");

        if ((PlayerPrefs.GetInt("TextDestoryLevel20") == 1))
        {
            Destroy(player.GetComponent<Level20Text>());
            Destroy(text);
            Destroy(EndingLights.GetComponent<Level20Walls>());
            EndingLights.AddComponent<WallFalse>();
        }
    }
}
