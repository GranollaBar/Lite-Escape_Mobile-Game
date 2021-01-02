using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpManager : MonoBehaviour
{
    public Animator fadeTransition;
    private float transitionTime = 1f;
    private float sceneStartTimer = 1.6f;
    private bool helpBackClicked = false;
    public ParticleSystem helpBackParticles;

    public System.Collections.IEnumerator FlashFade()
    {
        fadeTransition.SetTrigger("Fade Start");
        yield return new WaitForSeconds(transitionTime);
    }

    public void Update()
    {
        if (helpBackClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                SceneManager.LoadScene(0);
                helpBackClicked = false;
            }
        }
    }

    public void helpBack()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(FlashFade());
        helpBackClicked = true;
        Instantiate(helpBackParticles);
    }
}
