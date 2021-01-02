using UnityEngine;
using UnityEngine.SceneManagement;

public class DiscordManager : MonoBehaviour
{
    public Animator fadeTransition;
    private float transitionTime = 1f;
    private float sceneStartTimer = 1.6f;
    private bool discordBackClicked = false;
    public ParticleSystem discordBackParticles;

    public System.Collections.IEnumerator FlashFade()
    {
        fadeTransition.SetTrigger("Fade Start");
        yield return new WaitForSeconds(transitionTime);
    }

    public void Update()
    {
        if (discordBackClicked)
        {
            sceneStartTimer -= Time.deltaTime;
            if (sceneStartTimer <= 0)
            {
                SceneManager.LoadScene(0);
                discordBackClicked = false;
            }
        }
    }

    public void discordBack()
    {
        FindObjectOfType<AudioManager>().Play("Click Sound");
        StartCoroutine(FlashFade());
        discordBackClicked = true;
        Instantiate(discordBackParticles);
    }

    public void DiscordLink()
    {
        Application.OpenURL("https://discord.com/");
    }
}
