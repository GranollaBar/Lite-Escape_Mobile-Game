using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EffectObject : MonoBehaviour
{
    private GameObject player;
    public int respawn;
    public float time;
    public bool shakeCamera;

    [Range(0f, 1f)]
    public float duration;
    [Range(0f, 1f)]
    public float magnitude;

    void Start()
    {
        FindObjectOfType<CameraShake>().Shake(duration, magnitude);

        //if (shakeCamera)
        //    FindObjectOfType<CameraShake2>().StartShake(testProperties);

        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(player, time);
        StartCoroutine(waiter());
        FindObjectOfType<AudioManager>().Play("Death Sound");

    }
    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(respawn);

    }


}
