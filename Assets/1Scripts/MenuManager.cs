using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator circleTransition;
    public Animator fadeTransition;

    private float transitionTime = 1f;
    private float sceneStartTimer = 1.6f;

    private bool playClicked = false;

    public ParticleSystem playParticles;

    public GameObject music;
    public GameObject noMusic;
    public GameObject soundEffects;
    public GameObject noSoundEffects;

    public bool Truemusic;
    public bool TruesoundEffects;

    private GameObject AudioManager;

    private void Start()
    {
        Truemusic = true;
        TruesoundEffects = true;

        AudioManager = GameObject.FindGameObjectWithTag("AudioManager");
    }

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
                Destroy(AudioManager);
                SceneManager.LoadScene(1);
                playClicked = false;
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

    public void playMusic()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        music.SetActive(true);
        noMusic.SetActive(false);
        Truemusic = true;
    }

    public void playSoundEffects()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        soundEffects.SetActive(true);
        noSoundEffects.SetActive(false);
        TruesoundEffects = true;
    }


    public void playNoMusic()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        music.SetActive(false);
        noMusic.SetActive(true);
        Truemusic = false;
    }

    public void playNoSoundEffects()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        soundEffects.SetActive(false);
        noSoundEffects.SetActive(true);
        TruesoundEffects = false;
    }
}
