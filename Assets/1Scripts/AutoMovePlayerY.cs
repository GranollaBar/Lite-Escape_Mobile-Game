using UnityEngine;

public class AutoMovePlayerY : MonoBehaviour
{
    private GameObject exitDoor;
    private GameObject player;
    private Rigidbody2D playerRb;
    private Transform playerPosition;
    private bool movePlayer = false;
    private int moveTo;
    public GameObject stamina;
    public ParticleSystem confettiParticles;

    // Start is called before the first frame update
    void Start()
    {
        exitDoor = GameObject.FindGameObjectWithTag("ExitDoor");
        player = GameObject.FindGameObjectWithTag("Player");
        playerRb = player.GetComponent<Rigidbody2D>();
        playerPosition = player.GetComponent<Transform>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == exitDoor)
        {
            Instantiate(confettiParticles, transform.position, Quaternion.identity);

            Destroy(player.GetComponent<ballcontrol>());
            Destroy(player.GetComponent<LineRenderer>());
            playerRb.bodyType = RigidbodyType2D.Kinematic;
            playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
            moveTo = 100;
            movePlayer = true;

            stamina.SetActive(false);

            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;

            FindObjectOfType<AudioManager>().Play("Victory");
            FindObjectOfType<AudioManager>().Play("Clapping Sound");
        }
    }

    private void FixedUpdate()
    {

        if (movePlayer)
        {
            PlayerAutoMove();
            if (Mathf.Abs(playerPosition.position.y - moveTo) < 0.5)
            {
                movePlayer = false;
                playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
            }

        }
    }

    void PlayerAutoMove()
    {
        int moveAmount = 10;
        Vector3 targetVelocity = new Vector2(moveAmount * 1f, playerRb.velocity.x);
        Vector3 m_Velocity = Vector3.zero;
        float m_MovementSmoothing = .05f;
        playerRb.velocity = Vector3.SmoothDamp(playerRb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
    }

}
