using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator circleTransition;
    public Animator fadeTransition;

    private float transitionTime = 1f;
    private float sceneStartTimer = 1.6f;

    private bool playClicked = false;
    private bool discordClicked = false;
    private bool helpClicked = false;

    public ParticleSystem playParticles;
    public ParticleSystem discordParticles;
    public ParticleSystem helpParticles;

    public GameObject music;
    public GameObject noMusic;
    public GameObject soundEffects;
    public GameObject noSoundEffects;

    public System.Collections.IEnumerator CircleFade()
    {
        circleTransition.SetTrigger("Circle Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator FlashFade()
    {
        fadeTransition.SetTrigger("Fade Start");
        yield return new WaitForSeconds(transitionTime);
    }

    public void Update()
    {
        if (playClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0) 
            {
                SceneManager.LoadScene(3);
                playClicked = false;
            }
        }

        if (discordClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                SceneManager.LoadScene(2);
                discordClicked = false;
            }
        }

        if (helpClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                SceneManager.LoadScene(1);
                helpClicked = false;
            }
        }
    }

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        playClicked = true;
        Instantiate(playParticles);
    }

    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/granolla__bar/");
    }

    public void discordMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(FlashFade());
        discordClicked = true;
        Instantiate(discordParticles);
    }

    public void helpMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(FlashFade());
        helpClicked = true;
        Instantiate(helpParticles);
    }

    public void playNoMusic()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        music.SetActive(false);
        noMusic.SetActive(true);
    }

    public void playMusic()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        music.SetActive(true);
        noMusic.SetActive(false);
    }

    public void playNoSoundEffects()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        soundEffects.SetActive(false);
        noSoundEffects.SetActive(true);
    }

    public void playSoundEffects()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        soundEffects.SetActive(true);
        noSoundEffects.SetActive(false);
    }
}
