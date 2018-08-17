using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour 
{
    [Header("Player Variables")]
    public int playerMaxHealth;
    public int playerCurrHealth;

	void Start () 
    {
        //playerCurrHealth = playerMaxHealth;
        playerCurrHealth = Mathf.Clamp(playerCurrHealth, 0, playerMaxHealth);
	}
	
	void Update () 
    {
		if (playerCurrHealth <= 0)
        {
            gameObject.SetActive(false);
        }
	}

    public void DamagePlayer(int damageToGive)
    {
        playerCurrHealth -= damageToGive;
    }

    public void MaxHealth()
    {
        playerCurrHealth = playerMaxHealth;
    }
}
