using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovePlayer : MonoBehaviour
{
    public PlayerController playerMovement;

    private GameObject autoMove;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        autoMove = GameObject.FindGameObjectWithTag("AutoMovePlayer");
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == autoMove)
        {
            PlayerAutoMove();
        }

    }

    void PlayerAutoMove()
    {
        ballcontrol ball = player.GetComponent<ballcontrol>();
        ball.enabled = false;

        playerMovement.Move(100 * Time.fixedDeltaTime * 1, false);
    }

}
