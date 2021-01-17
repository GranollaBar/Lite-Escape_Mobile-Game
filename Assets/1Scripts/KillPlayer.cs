using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public int respawn;
    private GameObject enemy;
    private GameObject player;
    private GameObject cam;

    public ParticleSystem deathParticles;

    public Animator transition;

    private float transitionTime = 0.5f;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == enemy)
        {
            camInstruction(false);
            StartCoroutine(Destroy());
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
        Instantiate(deathParticles, transform.position, Quaternion.identity);

        Destroy(player);

        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;

        transition.SetTrigger("DeathStart");
        yield return new WaitForSeconds(transitionTime);
    }
}
