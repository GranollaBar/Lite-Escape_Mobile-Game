using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteManager : MonoBehaviour
{
    public Animator circleTransition;

    private float transitionTime = 1f;
    private float sceneStartTimer = 2f;

    private bool homeClicked = false;
    private bool restartClicked = false;
    private bool nextLevelClicked = false;

    private GameObject AudioManager;

    private void Start()
    {
        AudioManager = GameObject.FindGameObjectWithTag("AudioManager");
    }


    public System.Collections.IEnumerator CircleFade()
    {
        circleTransition.SetTrigger("Circle Start");
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

        if (nextLevelClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                nextLevelClicked = false;
            }
        }
    }

    public void HomeButton()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        homeClicked = true;
    }

    public void RestartButton()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        restartClicked = true;
    }

    public void NextLevelButton()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        nextLevelClicked = true;
    }
}
