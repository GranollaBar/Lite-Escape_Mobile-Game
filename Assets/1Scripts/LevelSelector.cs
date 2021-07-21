using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Animator circleTransition;

    private float transitionTime = 1f;
    private float sceneStartTimer = 1.6f;

    private bool tutorialClicked = false;
    private bool Level1Clicked = false;
    private bool Level2Clicked = false;
    private bool Level3Clicked = false;
    private bool Level4Clicked = false;
    private bool Level5Clicked = false;
    private bool Level6Clicked = false;
    private bool Level7Clicked = false;
    private bool Level8Clicked = false;
    private bool Level9Clicked = false;
    private bool Level10Clicked = false;
    private bool Level11Clicked = false;
    private bool Level12Clicked = false;
    private bool Level13Clicked = false;
    private bool Level14Clicked = false;
    private bool Level15Clicked = false;
    private bool Level16Clicked = false;
    private bool Level17Clicked = false;
    private bool Level18Clicked = false;
    private bool Level19Clicked = false;
    private bool Level20Clicked = false;
    private bool Level21Clicked = false;
    private bool Level22Clicked = false;
    private bool Level23Clicked = false;
    private bool Level24Clicked = false;
    private bool Level25Clicked = false;
    private bool Level26Clicked = false;

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
        if (tutorialClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(2);
                tutorialClicked = false;
            }
        }

        if (Level1Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(3);
                Level1Clicked = false;
            }
        }

        if (Level2Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(4);
                Level2Clicked = false;
            }
        }

        if (Level3Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(5);
                Level3Clicked = false;
            }
        }

        if (Level4Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(6);
                Level4Clicked = false;
            }
        }

        if (Level5Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(7);
                Level5Clicked = false;
            }
        }

        if (Level6Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(8);
                Level6Clicked = false;
            }
        }

        if (Level7Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(9);
                Level7Clicked = false;
            }
        }

        if (Level8Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(10);
                Level8Clicked = false;
            }
        }

        if (Level9Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(11);
                Level9Clicked = false;
            }
        }

        if (Level10Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(12);
                Level10Clicked = false;
            }
        }

        if (Level11Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(13);
                Level11Clicked = false;
            }
        }

        if (Level12Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(14);
                Level12Clicked = false;
            }
        }

        if (Level13Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(15);
                Level13Clicked = false;
            }
        }

        if (Level14Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(16);
                Level14Clicked = false;
            }
        }

        if (Level15Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(17);
                Level15Clicked = false;
            }
        }

        if (Level16Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(18);
                Level16Clicked = false;
            }
        }

        if (Level17Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(19);
                Level17Clicked = false;
            }
        }

        if (Level18Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(20);
                Level18Clicked = false;
            }
        }

        if (Level19Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(21);
                Level19Clicked = false;
            }
        }

        if (Level20Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(22);
                Level20Clicked = false;
            }
        }

        if (Level21Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(23);
                Level21Clicked = false;
            }
        }

        if (Level22Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(24);
                Level22Clicked = false;
            }
        }

        if (Level23Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(25);
                Level23Clicked = false;
            }
        }

        if (Level24Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(26);
                Level24Clicked = false;
            }
        }

        if (Level25Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(27);
                Level25Clicked = false;
            }
        }

        if (Level26Clicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(28);
                Level26Clicked = false;
            }
        }
    }

    public void TutorialLevel()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        tutorialClicked = true;
    }

    public void Level1()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level1Clicked = true;
    }

    public void Level2()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level2Clicked = true;
    }

    public void Level3()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level3Clicked = true;
    }

    public void Level4()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level4Clicked = true;
    }

    public void Level5()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level5Clicked = true;
    }

    public void Level6()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level6Clicked = true;
    }

    public void Level7()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level7Clicked = true;
    }

    public void Level8()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level8Clicked = true;
    }

    public void Level9()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level9Clicked = true;
    }

    public void Level10()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level10Clicked = true;
    }

    public void Level11()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level11Clicked = true;
    }

    public void Level12()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level12Clicked = true;
    }

    public void Level13()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level13Clicked = true;
    }

    public void Level14()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level14Clicked = true;
    }

    public void Level15()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level15Clicked = true;
    }

    public void Level16()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level16Clicked = true;
    }

    public void Level17()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level17Clicked = true;
    }

    public void Level18()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level18Clicked = true;
    }

    public void Level19()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level19Clicked = true;
    }

    public void Level20()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level20Clicked = true;
    }

    public void Level21()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level21Clicked = true;
    }

    public void Level22()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level22Clicked = true;
    }

    public void Level23()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level23Clicked = true;
    }

    public void Level24()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level24Clicked = true;
    }

    public void Level25()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level25Clicked = true;
    }

    public void Level26()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(CircleFade());
        Level26Clicked = true;
    }
}
