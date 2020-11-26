using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxstamina = 100;
	public int currentstamina;

	public StaminaBar staminaBar;

    // Start is called before the first frame update
    void Start()
    {
		currentstamina = maxstamina;
		staminaBar.SetMaxStamina(maxstamina);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}
    }

	void TakeDamage(int damage)
	{
		currentstamina -= damage;

		staminaBar.SetStamina(currentstamina);
	}
}
