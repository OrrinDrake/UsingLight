using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public enum PlayerDirection
    {
        N, S, E, W, NE, NW, SE, SW
    }
    
    
    //Player properties
    int health = 100;
    int stamina = 100;
    bool canDamage = true; //Always true unless the shield is up or stamina = 0
    float speed = 2.0f;
    public GameObject bullet;
    public GameObject sword; 
    Vector3 positionOfBullet;
    public Animator animator; 
    PlayerDirection playerDirection;
    string currentAnimation;
    
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.position += speed * transform.up * Time.deltaTime;
            transform.position -= speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x - .5f, transform.position.y + .5f, 0);
            playerDirection = PlayerDirection.NW;
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += speed * transform.up * Time.deltaTime;
            transform.position += speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x + .5f, transform.position.y + .5f, 0);
            playerDirection = PlayerDirection.NE;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= speed * transform.up * Time.deltaTime;
            transform.position -= speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x - .5f, transform.position.y - .5f, 0);
            playerDirection = PlayerDirection.SW;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= speed * transform.up * Time.deltaTime;
            transform.position += speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x + .5f, transform.position.y - .5f, 0);
            playerDirection = PlayerDirection.SE;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.Play("PlayerWalk");
            //transform.Translate((1) * Camera.main.transform.forward * Time.deltaTime);
            transform.position += speed * transform.up * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x, transform.position.y + .5f, 0);
            playerDirection = PlayerDirection.N;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate((-1) * Camera.main.transform.forward * Time.deltaTime);
            transform.position -= speed * transform.up * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x, transform.position.y - .5f, 0);
            playerDirection = PlayerDirection.S;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.Play("WalkLeft");
            //transform.Translate((-1) * Camera.main.transform.right * Time.deltaTime);
            transform.position -= speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x - .5f, transform.position.y, 0);
            playerDirection = PlayerDirection.W;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.Play("WalkRight");
            //transform.Translate((1) * Camera.main.transform.right * Time.deltaTime);
            transform.position += speed * transform.right * Time.deltaTime;
            positionOfBullet = new Vector3(transform.position.x + .5f, transform.position.y, 0);
            playerDirection = PlayerDirection.E;
        }

        if(Input.GetKeyUp(KeyCode.Z))
        {
            bullet.GetComponent<Bullets>().PlayerDirection = playerDirection.ToString();
            Instantiate(bullet, positionOfBullet, transform.rotation);
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            sword.GetComponent<Sword>().PlayerDirection = playerDirection.ToString();
            Instantiate(sword, new Vector3(transform.position.x, transform.position.y + .5f, 0), transform.rotation);
        }
            



    }
    void TransitionAnimation(string animationName)
    {
        if (currentAnimation != animationName)
        {
            animator.Play(animationName);
            currentAnimation = animationName;
        }

    }

    

    
}
