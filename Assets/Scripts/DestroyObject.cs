using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject deatheffect;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            deatheffect.SetActive(true);
        }
    }
}
