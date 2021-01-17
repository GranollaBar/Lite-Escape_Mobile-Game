using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathEffect : MonoBehaviour
{
    public Animator transition;

    private float transitionTime = 1f;

    public GameObject player;

    void Update()
    {
        if (player == null)
        {
            ReloadLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("DeathStart");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
