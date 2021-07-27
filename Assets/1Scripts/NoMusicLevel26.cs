using UnityEngine;

public class NoMusicLevel26 : MonoBehaviour
{
    void Start()
    {
        if ((PlayerPrefs.GetInt("NoMusicLevel26") == 1))
        {
            FindObjectOfType<AudioManager>().StopPlay("Main Theme");
            FindObjectOfType<AudioManager>().StopPlay("Last Theme");
        }
    }
}
