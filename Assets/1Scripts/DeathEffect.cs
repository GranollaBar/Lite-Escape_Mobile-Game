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
        if (player.transform.position.x >= 1000000000)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("DeathStart");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
