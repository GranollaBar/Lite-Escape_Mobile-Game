using UnityEngine;

public class NoMusic : MonoBehaviour
{
    void Start()
    {
        if ((PlayerPrefs.GetInt("NoMusic") == 1))
        {
            FindObjectOfType<AudioManager>().StopPlay("Main Theme");
        }
    }
}
