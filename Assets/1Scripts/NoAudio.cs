using UnityEngine;

public class NoAudio : MonoBehaviour
{
    private GameObject menu;
    private MenuManager menuManager;

    private void Start()
    {
        menu = GameObject.FindGameObjectWithTag("Menu");
        menuManager = menu.GetComponent<MenuManager>();
    }

    private void Update()
    {
        if (menuManager.Truemusic == false)
        {
            FindObjectOfType<AudioManager>().StopPlay("Main Theme");
        }

        if (menuManager.TruesoundEffects == false)
        {
            FindObjectOfType<AudioManager>().StopPlay("Death Sound");
            FindObjectOfType<AudioManager>().StopPlay("Air Sound");
            FindObjectOfType<AudioManager>().StopPlay("Clapping Sound");
            FindObjectOfType<AudioManager>().StopPlay("Victory");
            FindObjectOfType<AudioManager>().StopPlay("WallBreak");
        }
    }
}
