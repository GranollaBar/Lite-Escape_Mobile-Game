using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoMoveLastLevel : MonoBehaviour
{
    private GameObject exitDoor;
    private GameObject player;
    private Rigidbody2D playerRb;
    private Transform playerPosition;
    private bool movePlayer = false;
    public int moveTo;
    public GameObject stamina;
    public ParticleSystem confettiParticles;
    public Animator finalTransition;
    public Animator finalTextTransition;
    public Animator finalCircleTransition;
    private float finalTransitionTime = 4f;
    private float finalTextTransitionTime = 6f;
    private float finalCircleTransitionTime = 10f;
    private float sceneHomeTimer = 12f;
    private float trumpetTimer = 5.5f;
    public Button pauseButton;
    public bool moveUp;
    private SpriteRenderer playerSpriteRenderer;
    private TrailRenderer playerTrailRenderer;
    private GameObject finalLoaderCanvas;
    private Canvas myCanvas;
    private GameObject finalLoaderTextCanvas;
    private Canvas myTextCanvas;
    private GameObject AudioManager;
    private bool finalUpdating;
    private bool finalTheme;


    void Start()
    {
        exitDoor = GameObject.FindGameObjectWithTag("ExitDoor");
        player = GameObject.FindGameObjectWithTag("Player");
        playerRb = player.GetComponent<Rigidbody2D>();
        playerPosition = player.GetComponent<Transform>();
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
        playerTrailRenderer = player.GetComponent<TrailRenderer>();
        finalLoaderCanvas = GameObject.FindGameObjectWithTag("finalCanvas");
        myCanvas = finalLoaderCanvas.GetComponent<Canvas>();
        finalLoaderTextCanvas = GameObject.FindGameObjectWithTag("finalTextCanvas");
        myTextCanvas = finalLoaderTextCanvas.GetComponent<Canvas>();
        AudioManager = GameObject.FindGameObjectWithTag("AudioManager");
        finalUpdating = false;
    }

    public System.Collections.IEnumerator CompleteFinalLevel()
    {
        yield return new WaitForSeconds(finalTransitionTime);
        finalTransition.SetTrigger("Final Fade");
    }

    public System.Collections.IEnumerator CompleteFinalText()
    {
        yield return new WaitForSeconds(finalTextTransitionTime);
        finalTextTransition.SetTrigger("Final Text");
    }

    public System.Collections.IEnumerator ReturnHome()
    {
        yield return new WaitForSeconds(finalCircleTransitionTime);
        finalCircleTransition.SetTrigger("Circle Start");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == exitDoor)
        {
            Instantiate(confettiParticles, transform.position, Quaternion.identity);

            Destroy(player.GetComponent<ballcontrol>());
            Destroy(player.GetComponent<LineRenderer>());
            Destroy(player.GetComponent<CircleCollider2D>());
            playerRb.bodyType = RigidbodyType2D.Kinematic;
            playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
            movePlayer = true;

            stamina.SetActive(false);

            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;

            if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
            {
                FindObjectOfType<AudioManager>().Play("Victory");
                FindObjectOfType<AudioManager>().Play("Clapping Sound");
            }

            if ((PlayerPrefs.GetInt("NoMusicLevel26") == 0) || (PlayerPrefs.GetInt("NoMusic") == 0) || (PlayerPrefs.GetInt("NoMusicTutorial") == 0))
            {
                FindObjectOfType<AudioManager>().StopPlay("Main Theme");
            }

            pauseButton.GetComponent<Button>().interactable = false;

            playerSpriteRenderer.color = new Color(1f, 1f, 1f);

            playerTrailRenderer.startColor = Color.white;
            playerTrailRenderer.endColor = Color.black;

            myCanvas.sortingLayerName = "Final Fade";
            myTextCanvas.sortingLayerName = "Final Text Layer";

            finalUpdating = true;
            finalTheme = true;

            StartCoroutine(CompleteFinalLevel());
            StartCoroutine(CompleteFinalText());
            StartCoroutine(ReturnHome());
        }
    }

    private void Update()
    {
        if (finalTheme)
        {
            trumpetTimer -= Time.deltaTime;
            if (trumpetTimer <= 0)
            {
                if ((PlayerPrefs.GetInt("NoMusicLevel26") == 0) || (PlayerPrefs.GetInt("NoMusic") == 0) || (PlayerPrefs.GetInt("NoMusicTutorial") == 0))
                {
                    FindObjectOfType<AudioManager>().Play("Last Theme");
                }
                finalTheme = false;
            }
        }

        if (finalUpdating)
        {
            sceneHomeTimer -= Time.deltaTime;
            if (sceneHomeTimer <= 0)
            {
                Destroy(AudioManager);
                SceneManager.LoadScene(0);
                finalUpdating = false;
            }
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
        if (moveUp)
        {
            moveAmount = -10;
        }

        Vector3 targetVelocity = new Vector2(moveAmount, playerRb.velocity.y);
        Vector3 m_Velocity = Vector3.zero;
        float m_MovementSmoothing = .05f;
        playerRb.velocity = Vector3.SmoothDamp(playerRb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
    }

}
