using UnityEngine;

public class CameraBoundary : MonoBehaviour
{
    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;
    [SerializeField]
    float topLimit;
    [SerializeField]
    float bottomLimit;

    void Update()
    {
        transform.position = new Vector3
        (
          Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
          Mathf.Clamp(transform.position.x, bottomLimit, topLimit),
          transform.position.z
        );  
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(new Vector2(leftLimit, topLimit), new Vector2(rightLimit, topLimit));
        Gizmos.DrawLine(new Vector2(rightLimit, topLimit), new Vector2(rightLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(rightLimit, bottomLimit), new Vector2(leftLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(leftLimit, topLimit));
    }
}
