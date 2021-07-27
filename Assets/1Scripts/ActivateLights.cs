using UnityEngine;

public class ActivateLights : MonoBehaviour
{
    private GameObject player;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    private bool Updating;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        light1.SetActive(true);
        light2.SetActive(false);
        light3.SetActive(false);

        Updating = true;
    }

    void Update()
    {
        if (Updating)
        {
            if (player.transform.position.x >= 190 & player.transform.position.x < 407)
            {
                light1.SetActive(false);
                light2.SetActive(true);
            }

            if (player.transform.position.x >= 407)
            {
                light2.SetActive(false);
                light3.SetActive(true);
            }
        }

    }
}
