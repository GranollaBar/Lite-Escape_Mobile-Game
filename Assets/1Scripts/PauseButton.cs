using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public Animator pauseTransition;

    private float transitionTime = 0.5f;

    private GameObject player;
    public GameObject StaminaBar;

    private SpriteRenderer myRenderer;
    private TrailRenderer myTrailRenderer;

    public Button pauseButton;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        myRenderer = player.GetComponent<SpriteRenderer>();
        myTrailRenderer = player.GetComponent<TrailRenderer>();

        int keepCounting = PlayerPrefs.GetInt("keepCounting", 0);
        int keepUpdating = PlayerPrefs.GetInt("keepUpdating", 0);
    }

    public System.Collections.IEnumerator PauseFade()
    {
        pauseTransition.SetTrigger("Pause Fade");
        yield return new WaitForSeconds(transitionTime);
    }

    public void PauseGame()
    {
        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Click Sound");
        }

        StartCoroutine(PauseFade());
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        player.GetComponent<ballcontrol>().enabled = false;
        player.GetComponent<LineRenderer>().enabled = false;
        player.GetComponent<TrailRenderer>().enabled = false;

        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;

        StaminaBar.SetActive(false);

        pauseButton.GetComponent<Button>().interactable = false;

        myRenderer.color = new Color(1f, 1f, 1f);

        myTrailRenderer.startColor = Color.white;
        myTrailRenderer.endColor = Color.black;

        PlayerPrefs.SetInt("keepCounting", 1);
        PlayerPrefs.SetInt("keepUpdating", 1); 
    }
}