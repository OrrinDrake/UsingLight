using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    public string PlayerDirection;
    float speed = 2.0f;
    GameObject player;
    Animator animator;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () {
        switch (PlayerDirection)
        {
            case "NE":
                animator.Play("SwingForward");
                //transform.RotateAround(player.transform.position, new Vector3(0.0f, 1.0f, 0.0f), 100 * Time.deltaTime); 
                
                break;
            case "NW":
                transform.position += speed * transform.up * Time.deltaTime;
                transform.position -= speed * transform.right * Time.deltaTime;
                break;
            case "SE":
                transform.position -= speed * transform.up * Time.deltaTime;
                transform.position += speed * transform.right * Time.deltaTime;
                break;
            case "SW":
                transform.position -= speed * transform.up * Time.deltaTime;
                transform.position -= speed * transform.right * Time.deltaTime;
                break;
            case "N":
                animator.Play("SwingForward");

                //transform.RotateAround(player.transform.position, new Vector3(1.0f, 0.0f, 0.0f), 100 * Time.deltaTime);

                break;
            case "S":
                transform.position -= speed * transform.up * Time.deltaTime;
                break;
            case "W":
                transform.position -= speed * transform.right * Time.deltaTime;
                break;
            case "E":
                transform.position += speed * transform.right * Time.deltaTime;
                break;
            default:
                Destroy(gameObject);
                break;

        }
    }
}
