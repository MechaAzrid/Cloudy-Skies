using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnemyController : MonoBehaviour 
{
    public int damageToGive;
	void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().DamagePlayer(damageToGive);
        }
    }
}
