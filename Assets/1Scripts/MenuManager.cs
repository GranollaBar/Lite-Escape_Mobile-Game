using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator transition;
    private float transitionTime = 1f;
    private float sceneStartTimer = 1.6f;
    private bool playClicked = false;
    private bool shopClicked = false;
    public ParticleSystem playParticles;
    public ParticleSystem shopParticles;

    public System.Collections.IEnumerator doFade()
    {
        transition.SetTrigger("Circle Start");
        yield return new WaitForSeconds(transitionTime);
    }

    public void Update()
    {
        if (playClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0) 
            {
                SceneManager.LoadScene(2);
                playClicked = false;
            }
        }

        if (shopClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                SceneManager.LoadScene(1);
                shopClicked = false;
            }
        }
    }

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(doFade());
        playClicked = true;
        Instantiate(playParticles);
    }

    public void shopMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(doFade());
        shopClicked = true;
        Instantiate(shopParticles);
    }

    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/granolla__bar/");
    }
}
