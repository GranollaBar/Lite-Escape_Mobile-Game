using UnityEngine;

public class RemoveText6 : MonoBehaviour
{
    private GameObject player;
    private GameObject EndingLights;
    private GameObject text;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EndingLights = GameObject.FindGameObjectWithTag("EndingLights");
        text = GameObject.FindGameObjectWithTag("text");

        if ((PlayerPrefs.GetInt("TextDestoryLevel6") == 1))
        {
            Destroy(player.GetComponent<Level6Text>());
            Destroy(text);
            Destroy(EndingLights.GetComponent<Level6Walls>());
            EndingLights.AddComponent<WallFalse>();
        }
    }
}
