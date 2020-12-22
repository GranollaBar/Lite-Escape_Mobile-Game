using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader2 : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    private GameObject player;
    private Transform playerPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPosition = player.GetComponent<Transform>();
    }



    void Update()
    {
        if (playerPosition.position.x >= 18)
        {
            LoadNextLevel2();
        }
    }

    public void LoadNextLevel2()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Circle Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
