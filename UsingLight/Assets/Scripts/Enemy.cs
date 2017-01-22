using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    int health = 100;
    int hitdamage;
    float distanceToPlayer;
    float speed = 2.0f;
    GameObject Player;

	// Use this for initialization
	void Start () {
        //Find player object 
        Player = GameObject.FindObjectOfType<Player>().gameObject;  
	}
	
	// Update is called once per frame
	void Update () {
        distanceToPlayer = Vector2.Distance(Player.transform.position, gameObject.transform.position);

        if (distanceToPlayer < 5f)
        {
            //Start moving towards the player 
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, Player.transform.position, speed * Time.deltaTime);
        }

        if(distanceToPlayer < 1)
        {
            //Start attacking the player

        }


	}
}
