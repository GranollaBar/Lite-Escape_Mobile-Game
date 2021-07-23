using UnityEngine;

public class NoSoundEffectsMenu : MonoBehaviour
{
    void Start()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsMenu") == 1))
        {
            FindObjectOfType<AudioManager>().StopPlay("Click Sound");
        }
    }
}
