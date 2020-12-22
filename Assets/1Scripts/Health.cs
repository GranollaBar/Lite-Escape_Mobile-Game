using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Health : MonoBehaviour
{

    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    private HealthLevel healthLevel;

    private void Start()
    {
        GameObject healthManager = GameObject.FindGameObjectWithTag("HealthManager");
        healthLevel = healthManager.GetComponent<HealthLevel>();
        Debug.Log("health =" + healthLevel.getHealth());
    }

    void Update()
    {
        if (healthLevel.getHealth() > numOfHearts)
        {
            healthLevel.setHealth(numOfHearts);
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < healthLevel.getHealth())
            {
                hearts[i].sprite = fullHeart;
            }

            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void decreaseHealth()
    {
        healthLevel.decreaseHealth();
    }
}
