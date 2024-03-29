﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public Animator circleTransition;
    public Animator pauseTransition;

    private float transitionTime = 1f;
    private float sceneStartTimer = 2f;

    private bool homeClicked = false;
    private bool restartClicked = false;
    private bool ContinueSearching = false;

    public GameObject music;
    public GameObject noMusic;
    public GameObject soundEffects;
    public GameObject noSoundEffects;

    private GameObject AudioManager;

    private GameObject player;
    private Rigidbody2D playerRb;

    private GameObject pauseMenu;

    public Button pauseButton;
 
    private void Start()
    {
        AudioManager = GameObject.FindGameObjectWithTag("AudioManager");

        music.SetActive(false);
        noMusic.SetActive(false);
        soundEffects.SetActive(false);
        noSoundEffects.SetActive(false);

        player = GameObject.FindGameObjectWithTag("Player");

        playerRb = player.GetComponent<Rigidbody2D>();
        pauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");

        if ((PlayerPrefs.GetInt("NoMusicTutorial") == 0) || (PlayerPrefs.GetInt("NoMusic") == 0) || (PlayerPrefs.GetInt("NoMusicLevel26") == 0))
        {
            music.SetActive(true);
            noMusic.SetActive(false);
        }

        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            soundEffects.SetActive(true);
            noSoundEffects.SetActive(false);
        }

        if ((PlayerPrefs.GetInt("NoMusicTutorial") == 1) || (PlayerPrefs.GetInt("NoMusic") == 1) || (PlayerPrefs.GetInt("NoMusicLevel26") == 1))
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

    public System.Collections.IEnumerator PauseLeaveFade()
    {
        pauseTransition.SetTrigger("Pause Leave");
        yield return new WaitForSeconds(transitionTime);
    }

    public void Update()
    {
        if (homeClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(0);
                homeClicked = false;
            }
        }

        if (restartClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                restartClicked = false;
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

    public void Home()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        homeClicked = true;
        PlayerPrefs.SetInt("NoContinueTimer", 0);
        PlayerPrefs.SetInt("keepUpdating", 1);
        PlayerPrefs.SetInt("keepCounting", 0);
        StartCoroutine(CircleFade());
    }

    public void Restart()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        restartClicked = true;
        PlayerPrefs.SetInt("NoContinueTimer", 0);
        PlayerPrefs.SetInt("keepUpdating", 1);
        PlayerPrefs.SetInt("keepCounting", 0);
        StartCoroutine(CircleFade());
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
        PlayerPrefs.SetInt("NoMusicLevel26", 0);

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
        music.SetActive(false);
        noMusic.SetActive(true);

        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        PlayerPrefs.SetInt("NoMusicTutorial", 1);
        PlayerPrefs.SetInt("NoMusic", 1);
        PlayerPrefs.SetInt("NoMusicLevel26", 1);

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

    public void close()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(PauseLeaveFade());
        playerRb.constraints = RigidbodyConstraints2D.None;
        pauseMenu.SetActive(false);
        pauseMenu.SetActive(true);

        player.GetComponent<ballcontrol>().enabled = true;
        player.GetComponent<LineRenderer>().enabled = true;
        player.GetComponent<TrailRenderer>().enabled = true;
        Vector3 newPos = new Vector3(player.transform.position.x + 0.001f, player.transform.position.y, player.transform.position.z);
        player.transform.position = newPos;

        pauseButton.GetComponent<Button>().interactable = true;

        PlayerPrefs.SetInt("keepUpdating", 1);
        PlayerPrefs.SetInt("keepCounting", 0);
    }
}
