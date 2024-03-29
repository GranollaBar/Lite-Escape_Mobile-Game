﻿using UnityEngine.UI;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public float power = 5;
    public float maxDrag = 5f;
    public Rigidbody2D rb;
    public LineRenderer lr;

    Vector3 dragStartPos;
    Touch touch;

    public Slider staminaBar;
    public float maxStamina;
    public float staminaLoss;
    public GameObject stamina;

    private SpriteRenderer myRenderer;
    private TrailRenderer myTrailRenderer;

    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myTrailRenderer = gameObject.GetComponent<TrailRenderer>();

        staminaBar.maxValue = maxStamina;
    }

    private void Update() 
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                DragStart();
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Dragging();
            }

            if (touch.phase == TouchPhase.Ended)
            {
                DragRelease();
            }
        }
    }

    void DragStart()
    {
        dragStartPos = Camera.main.ScreenToWorldPoint(touch.position);
        dragStartPos.z = 0f;
        lr.positionCount = 1;
        lr.SetPosition(0, dragStartPos);

        myRenderer.color = new Color(0f, 0.8f, 1f);

        myTrailRenderer.startColor = new Color(0f, 0.8f, 1f);
        myTrailRenderer.endColor = Color.black;

        stamina.SetActive(true);

        if (maxStamina <= 0)
        {
            stamina.SetActive(false);

            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }
    void Dragging()
    {
        Vector3 draggingPos = Camera.main.ScreenToWorldPoint(touch.position);
        draggingPos.z = 0f;
        lr.positionCount = 2;
        lr.SetPosition(1, draggingPos);

        myRenderer.color = new Color(0f, 0.8f, 1f);

        myTrailRenderer.startColor = new Color(0f, 0.8f, 1f);
        myTrailRenderer.endColor = Color.black;

        stamina.SetActive(true);

        maxStamina -= staminaLoss = Time.deltaTime;
        staminaBar.value = maxStamina;

        Time.timeScale = 0.5f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;

        if (maxStamina <= 0)
        {
            stamina.SetActive(false);

            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }
    void DragRelease()
    {
        lr.positionCount = 0;

        Vector3 dragReleasePos = Camera.main.ScreenToWorldPoint(touch.position);
        dragReleasePos.z = 0f;

        Vector3 force = dragStartPos - dragReleasePos;
        Vector3 ClampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;

        rb.AddForce(ClampedForce, ForceMode2D.Impulse);

        myRenderer.color = new Color(1f, 1f, 1f);

        myTrailRenderer.startColor = Color.white;
        myTrailRenderer.endColor = Color.black;

        stamina.SetActive(false);

        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;

        if ((PlayerPrefs.GetInt("NoSoundEffectsTutorial") == 0) || (PlayerPrefs.GetInt("NoSoundEffects") == 0) || (PlayerPrefs.GetInt("NoSoundEffectsMenu") == 0))
        {
            FindObjectOfType<AudioManager>().Play("Air Sound");
        }
    }
}
