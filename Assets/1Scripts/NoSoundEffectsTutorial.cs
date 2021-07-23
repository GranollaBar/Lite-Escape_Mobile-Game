using UnityEngine;

public class NoSoundEffectsTutorial : MonoBehaviour
{
    void Start()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 1))
        {
            FindObjectOfType<AudioManager>().StopPlay("Death Sound");
            FindObjectOfType<AudioManager>().StopPlay("Air Sound");
            FindObjectOfType<AudioManager>().StopPlay("Clapping Sound");
            FindObjectOfType<AudioManager>().StopPlay("Lights");
            FindObjectOfType<AudioManager>().StopPlay("Victory");
            FindObjectOfType<AudioManager>().StopPlay("WallBreak");
            FindObjectOfType<AudioManager>().StopPlay("Click Sound");
        }
    }
}
