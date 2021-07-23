using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public Animator pauseTransition;

    private float transitionTime = 0.5f;

    private GameObject player;
    private Rigidbody2D playerRb;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerRb = player.GetComponent<Rigidbody2D>();
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
        playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}