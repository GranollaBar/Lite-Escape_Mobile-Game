using UnityEngine;

public class HealthLevel : MonoBehaviour
{
    private static int health = 16;

    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void setHealth(int healthNumber)
    {
        health = healthNumber;
    }

    public int getHealth()
    {
        return health;
    }

    public void decreaseHealth()
    {
        health = health - 1;
    }
}
