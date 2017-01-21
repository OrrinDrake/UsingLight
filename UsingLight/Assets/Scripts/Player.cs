using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    //Player properties
    int health = 100;
    int stamina = 100;
    bool canDamage = true; //Always true unless the shield is up or stamina = 0
    float speed = 2.0f;
    string playerDirection;
    public GameObject bullet;
    Vector3 positionOfBullet;
    
    
	void Start () {
        

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += speed * transform.up * Time.deltaTime;
            transform.position -= speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x - .5f, transform.position.y + .5f, 0);
            playerDirection = "NW";
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += speed * transform.up * Time.deltaTime;
            transform.position += speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x + .5f, transform.position.y + .5f, 0);
            playerDirection = "NE";
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= speed * transform.up * Time.deltaTime;
            transform.position -= speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x - .5f, transform.position.y - .5f, 0);
            playerDirection = "SW";
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= speed * transform.up * Time.deltaTime;
            transform.position += speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x + .5f, transform.position.y - .5f, 0);
            playerDirection = "SE";
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.Translate((1) * Camera.main.transform.forward * Time.deltaTime);
            transform.position += speed * transform.up * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x, transform.position.y + .5f, 0);
            playerDirection = "N";
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate((-1) * Camera.main.transform.forward * Time.deltaTime);
            transform.position -= speed * transform.up * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x, transform.position.y - .5f, 0);

            playerDirection = "S";
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate((-1) * Camera.main.transform.right * Time.deltaTime);
            transform.position -= speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x - .5f, transform.position.y, 0);

            playerDirection = "W";
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate((1) * Camera.main.transform.right * Time.deltaTime);
            transform.position += speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x + .5f, transform.position.y, 0);
            playerDirection = "E";
        }

        if(Input.GetKeyUp(KeyCode.Z))
        {
            bullet.GetComponent<Bullets>().PlayerDirection = playerDirection;
            Instantiate(bullet, positionOfBullet, transform.rotation);


        }



    }

    
}
