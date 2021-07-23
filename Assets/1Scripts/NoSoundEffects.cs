using UnityEngine;

public class NoSoundEffects : MonoBehaviour
{
    void Start()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffects") == 1))
        {
            FindObjectOfType<AudioManager>().StopPlay("Death Sound");
            FindObjectOfType<AudioManager>().StopPlay("Air Sound");
            FindObjectOfType<AudioManager>().StopPlay("Clapping Sound");
            FindObjectOfType<AudioManager>().StopPlay("Victory");
            FindObjectOfType<AudioManager>().StopPlay("WallBreak");
            FindObjectOfType<AudioManager>().StopPlay("Click Sound");
        }
    }
}
