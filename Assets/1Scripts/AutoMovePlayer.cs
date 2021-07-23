using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoMovePlayer : MonoBehaviour
{
    private GameObject exitDoor;
    private GameObject player;
    private GameObject lights;
    private Rigidbody2D playerRb;
    private Transform playerPosition;
    private bool movePlayer = false; 
    public int moveTo;
    public GameObject stamina;
    public ParticleSystem confettiParticles;
    public Animator levelCompleteTransition;
    private float levelCompleteTransitionTime = 5f;
    private int nextSceneLoad;

    // Start is called before the first frame update
    void Start()
    {
        exitDoor = GameObject.FindGameObjectWithTag("ExitDoor");
        player = GameObject.FindGameObjectWithTag("Player");
        lights = GameObject.FindGameObjectWithTag("MainLights");
        playerRb = player.GetComponent<Rigidbody2D>();
        playerPosition = player.GetComponent<Transform>();
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public System.Collections.IEnumerator CompleteLevel()
    {
        yield return new WaitForSeconds(levelCompleteTransitionTime);
        levelCompleteTransition.SetTrigger("Level Complete");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == exitDoor)
        {
            Instantiate(confettiParticles, transform.position, Quaternion.identity);

            lights.SetActive(false);
            Destroy(player.GetComponent<ballcontrol>());
            Destroy(player.GetComponent<LineRenderer>());
            Destroy(player.GetComponent<CircleCollider2D>());
            playerRb.bodyType = RigidbodyType2D.Kinematic;
            playerRb.constraints = RigidbodyConstraints2D.FreezePositionY; 
            movePlayer = true;

            stamina.SetActive(false);

            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;

            if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
            {
                FindObjectOfType<AudioManager>().Play("Victory");
                FindObjectOfType<AudioManager>().Play("Clapping Sound");
            }

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }

            StartCoroutine(CompleteLevel());
        }
    }

    private void FixedUpdate()
    {

        if (movePlayer)
        {
            PlayerAutoMove();
            if (Mathf.Abs(playerPosition.position.x - moveTo) < 0.5)
            {
                movePlayer = false;
                playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
            }

        }
    }

    void PlayerAutoMove()
    {
        int moveAmount = 10;
        Vector3 targetVelocity = new Vector2(moveAmount * 1f, playerRb.velocity.y);
        Vector3 m_Velocity = Vector3.zero;
        float m_MovementSmoothing = .05f;
        playerRb.velocity = Vector3.SmoothDamp(playerRb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
    }

}
