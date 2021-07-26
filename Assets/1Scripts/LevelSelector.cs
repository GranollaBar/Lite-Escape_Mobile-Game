using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    private bool backClicked = false;

    private GameObject AudioManager;

    public Button tutorialButton;
    public Button level1Button;
    public Button level2Button;
    public Button level3Button;
    public Button level4Button;
    public Button level5Button;
    public Button level6Button;
    public Button level7Button;
    public Button level8Button;
    public Button level9Button;
    public Button level10Button;
    public Button level11Button;
    public Button level12Button;
    public Button level13Button;
    public Button level14Button;
    public Button level15Button;
    public Button level16Button;
    public Button level17Button;
    public Button level18Button;
    public Button level19Button;
    public Button level20Button;
    public Button level21Button;
    public Button level22Button;
    public Button level23Button;
    public Button level24Button;
    public Button level25Button;
    public Button level26Button;
    public Button backButton;

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

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
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(28);
                Level26Clicked = false;
            }
        }

        if (backClicked)
        {
            if (PlayerPrefs.GetInt("levelAt") > 1)
            {
                backButton.GetComponent<Button>().enabled = false;
                tutorialButton.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 2)
            {
                level1Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 3)
            {
                level2Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 4)
            {
                level3Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 5)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 6)
            {
                level5Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 7)
            {
                level6Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 8)
            {
                level7Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 9)
            {
                level8Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 10)
            {
                level9Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 11)
            {
                level10Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 12)
            {
                level11Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 13)
            {
                level12Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 14)
            {
                level13Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 15)
            {
                level4Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 16)
            {
                level14Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 17)
            {
                level15Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 18)
            {
                level16Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 19)
            {
                level17Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 20)
            {
                level18Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 21)
            {
                level19Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 22)
            {
                level20Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 23)
            {
                level21Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 24)
            {
                level22Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 25)
            {
                level23Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 26)
            {
                level24Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 27)
            {
                level25Button.GetComponent<Button>().enabled = false;
            }

            if (PlayerPrefs.GetInt("levelAt") > 28)
            {
                level26Button.GetComponent<Button>().enabled = false;
            }

            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(0);
                backClicked = false;
            }
        }
    }

    public void TutorialLevel()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        tutorialClicked = true;
    }

    public void Level1()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level1Clicked = true;
    }

    public void Level2()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level2Clicked = true;
    }

    public void Level3()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level3Clicked = true;
    }

    public void Level4()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level4Clicked = true;
    }

    public void Level5()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level5Clicked = true;
    }

    public void Level6()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level6Clicked = true;
    }

    public void Level7()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level7Clicked = true;
    }

    public void Level8()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level8Clicked = true;
    }

    public void Level9()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level9Clicked = true;
    }

    public void Level10()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level10Clicked = true;
    }

    public void Level11()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level11Clicked = true;
    }

    public void Level12()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level12Clicked = true;
    }

    public void Level13()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level13Clicked = true;
    }

    public void Level14()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level14Clicked = true;
    }

    public void Level15()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level15Clicked = true;
    }

    public void Level16()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level16Clicked = true;
    }

    public void Level17()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level17Clicked = true;
    }

    public void Level18()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level18Clicked = true;
    }

    public void Level19()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level19Clicked = true;
    }

    public void Level20()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level20Clicked = true;
    }

    public void Level21()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level21Clicked = true;
    }

    public void Level22()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level22Clicked = true;
    }

    public void Level23()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level23Clicked = true;
    }

    public void Level24()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level24Clicked = true;
    }

    public void Level25()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level25Clicked = true;
    }

    public void Level26()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        Level26Clicked = true;
    }

    public void Back()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(CircleFade());
        backClicked = true;
    }
}
