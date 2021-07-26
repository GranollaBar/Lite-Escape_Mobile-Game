using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    private GameObject[] enemy;
    private GameObject player;
    private GameObject cam;

    public ParticleSystem deathParticles;

    public Animator transition;

    private float transitionTime = 1f;

    private int SceneLoad;

    public Button pauseButton;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player");

        int TextDestoryTutorial = PlayerPrefs.GetInt("TextDestoryTutorial", 0);
        int TextDestoryLevel1 = PlayerPrefs.GetInt("TextDestoryLevel1", 0);
        int TextDestoryLevel5 = PlayerPrefs.GetInt("TextDestoryLevel5", 0);
        int TextDestoryLevel6 = PlayerPrefs.GetInt("TextDestoryLevel6", 0);
        int TextDestoryLevel10 = PlayerPrefs.GetInt("TextDestoryLevel10", 0);
        int TextDestoryLevel11 = PlayerPrefs.GetInt("TextDestoryLevel11", 0);
        int TextDestoryLevel15 = PlayerPrefs.GetInt("TextDestoryLevel15", 0);
        int TextDestoryLevel16 = PlayerPrefs.GetInt("TextDestoryLevel16", 0);
        int TextDestoryLevel20 = PlayerPrefs.GetInt("TextDestoryLevel20", 0);
        int TextDestoryLevel21 = PlayerPrefs.GetInt("TextDestoryLevel21", 0);
        int TextDestoryLevel25 = PlayerPrefs.GetInt("TextDestoryLevel25", 0);


        SceneLoad = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i =0; i < enemy.Length; i++)
        {
            if (other.gameObject == enemy[i])
            {
                camInstruction(false);
                StartCoroutine(Destroy());
            }
        }
    }

 
    void camInstruction(bool keepGoing)
    {
        cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        var cinemachine = cam.GetComponent<Cinemachine.CinemachineBrain>();
        cinemachine.enabled = keepGoing;
    }

    public System.Collections.IEnumerator Destroy()
    {
        if (SceneLoad == 2)
        {
            PlayerPrefs.SetInt("TextDestoryTutorial", 1);
        }

        if (SceneLoad == 3)
        {
            PlayerPrefs.SetInt("TextDestoryLevel1", 1);
        }

        if (SceneLoad == 7)
        {
            PlayerPrefs.SetInt("TextDestoryLevel5", 1);
        }

        if (SceneLoad == 8)
        {
            PlayerPrefs.SetInt("TextDestoryLevel6", 1);
        }

        if (SceneLoad == 12)
        {
            PlayerPrefs.SetInt("TextDestoryLevel10", 1);
        }

        if (SceneLoad == 13)
        {
            PlayerPrefs.SetInt("TextDestoryLevel11", 1);
        }

        if (SceneLoad == 17)
        {
            PlayerPrefs.SetInt("TextDestoryLevel15", 1);
        }

        if (SceneLoad == 18)
        {
            PlayerPrefs.SetInt("TextDestoryLevel16", 1);
        }

        if (SceneLoad == 22)
        {
            PlayerPrefs.SetInt("TextDestoryLevel20", 1);
        }

        if (SceneLoad == 23)
        {
            PlayerPrefs.SetInt("TextDestoryLevel21", 1);
        }

        if (SceneLoad == 27)
        {
            PlayerPrefs.SetInt("TextDestoryLevel25", 1);
        }

        Instantiate(deathParticles, transform.position, Quaternion.identity);

        Destroy(player);

        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;

        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Death Sound");
        }

        player.GetComponent<ballcontrol>().enabled = false;
        pauseButton.GetComponent<Button>().interactable = false;

        transition.SetTrigger("DeathStart");
        yield return new WaitForSeconds(transitionTime);
    }
}
