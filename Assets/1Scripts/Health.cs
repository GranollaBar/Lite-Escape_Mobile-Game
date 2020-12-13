using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    private string path = "Assets/Resources/health.txt";

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Start()
    {
        StreamReader reader = new StreamReader(path);
        string healthAsString = reader.ReadLine();
        reader.Close();
        health = int.Parse(healthAsString);
        Debug.Log("health =" + health);
    }

    void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
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
        health = health - 1;
        FileStream fcreate = File.Open(path, FileMode.Create);
        StreamWriter writer = new StreamWriter(fcreate);
        writer.WriteLine(health.ToString());
        writer.Close();
    }
}
