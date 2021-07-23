using UnityEngine;

public class RemoveText1 : MonoBehaviour
{
    private GameObject player;
    private GameObject EndingLights;
    private GameObject text;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EndingLights = GameObject.FindGameObjectWithTag("EndingLights");
        text = GameObject.FindGameObjectWithTag("text");

        if ((PlayerPrefs.GetInt("TextDestoryLevel1") == 1))
        {
            Destroy(player.GetComponent<Level1Text>());
            Destroy(text);
            Destroy(EndingLights.GetComponent<Level1Walls>());
            EndingLights.AddComponent<WallFalse>();
        }
    }
}
