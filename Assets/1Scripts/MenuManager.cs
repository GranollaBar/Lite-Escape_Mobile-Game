using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator circleTransition;
    public Animator fadeTransition;

    private float transitionTime = 1f;
    private float sceneStartTimer = 1.6f;

    private bool playClicked = false;
    private bool ContinueSearching = false;

    public ParticleSystem playParticles;

    public GameObject music;
    public GameObject noMusic;
    public GameObject soundEffects;
    public GameObject noSoundEffects;

    private GameObject AudioManager;

    private void Start()
    {
        AudioManager = GameObject.FindGameObjectWithTag("AudioManager");

        int NoMusicTutorial = PlayerPrefs.GetInt("NoMusicTutorial", 0);
        int NoMusic = PlayerPrefs.GetInt("NoMusic", 0);
        int NoSoundEffectsTutorial = PlayerPrefs.GetInt("NoSoundEffectsTutorial", 0);
        int NoSoundEffectsMenu = PlayerPrefs.GetInt("NoSoundEffectsMenu", 0);
        int NoSoundEffects = PlayerPrefs.GetInt("NoSoundEffects", 0);

        music.SetActive(false);
        noMusic.SetActive(false);
        soundEffects.SetActive(false);
        noSoundEffects.SetActive(false);

        if ((PlayerPrefs.GetInt("NoMusicTutorial") == 0) || (PlayerPrefs.GetInt("NoMusic") == 0))
        {
            music.SetActive(true);
            noMusic.SetActive(false);
        }

        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            soundEffects.SetActive(true);
            noSoundEffects.SetActive(false);
        }

        if ((PlayerPrefs.GetInt("NoMusicTutorial") == 1) || (PlayerPrefs.GetInt("NoMusic") == 1))
        {
            music.SetActive(false);
            noMusic.SetActive(true);
        }

        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 1) || (PlayerPrefs.GetInt("NoSoundEffects") == 1) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 1))
        {
            soundEffects.SetActive(false);
            noSoundEffects.SetActive(true);
        }
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

        if (ContinueSearching)
        {
            if ((PlayerPrefs.GetInt("NoMusic") == 0) || (PlayerPrefs.GetInt("NoMusicTutorial") == 0))
            {
                FindObjectOfType<AudioManager>().Play("Main Theme");
                ContinueSearching = false;
            }

            else
            {
                FindObjectOfType<AudioManager>().StopPlay("Main Theme");
                ContinueSearching = false;
            }

        }
    }

    public void PlayGame()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        Instantiate(playParticles);
        playClicked = true;
        StartCoroutine(CircleFade());
    }

    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/granolla__bar/");
    }

    public void playMusic()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        music.SetActive(true);
        noMusic.SetActive(false);

        PlayerPrefs.SetInt("NoMusicTutorial", 0);
        PlayerPrefs.SetInt("NoMusic", 0);

        ContinueSearching = true;
    }

    public void playSoundEffects()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        soundEffects.SetActive(true);
        noSoundEffects.SetActive(false);

        PlayerPrefs.SetInt("NoSoundEffectsTutorial", 0);
        PlayerPrefs.SetInt("NoSoundEffects", 0);
        PlayerPrefs.SetInt("NoSoundEffectsMenu", 0); 
    }


    public void playNoMusic()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        music.SetActive(false);
        noMusic.SetActive(true);

        PlayerPrefs.SetInt("NoMusicTutorial", 1);
        PlayerPrefs.SetInt("NoMusic", 1);

        ContinueSearching = true;
    }

    public void playNoSoundEffects()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        soundEffects.SetActive(false);
        noSoundEffects.SetActive(true);

        PlayerPrefs.SetInt("NoSoundEffectsTutorial", 1);
        PlayerPrefs.SetInt("NoSoundEffects", 1);
        PlayerPrefs.SetInt("NoSoundEffectsMenu", 1);
    }
}
