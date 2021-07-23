using UnityEngine;

public class NoMusicTutorial : MonoBehaviour
{
    void Start()
    {
        if ((PlayerPrefs.GetInt("NoMusicTutorial") == 1))
        {
            FindObjectOfType<AudioManager>().StopPlay("Main Theme");
            FindObjectOfType<AudioManager>().StopPlay("Scary");
        }
    }
}
