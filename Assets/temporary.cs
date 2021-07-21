using UnityEngine.UI;
using UnityEngine;

public class temporary : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minpower;
    public Vector2 maxpower;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    private SpriteRenderer myRenderer;
    private TrailRenderer myTrailRenderer;

    private void Start()
    {
        cam = Camera.main;

        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myTrailRenderer = gameObject.GetComponent<TrailRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;

            myRenderer.color = new Color(0f, 0.8f, 1f);

            myTrailRenderer.startColor = new Color(0f, 0.8f, 1f);
            myTrailRenderer.endColor = Color.black;
        }

        if (Input.GetMouseButtonUp(0))
        {
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minpower.x, maxpower.x), Mathf.Clamp(startPoint.y - endPoint.y, minpower.y, maxpower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);

            myRenderer.color = new Color(1f, 1f, 1f);

            myTrailRenderer.startColor = Color.white;
            myTrailRenderer.endColor = Color.black;

        }
    }
}
