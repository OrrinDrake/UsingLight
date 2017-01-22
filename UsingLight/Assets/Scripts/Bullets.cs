using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {


    float speed =20.0f;
    public string PlayerDirection;
    float timer = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
            Destroy(gameObject);
        switch(PlayerDirection)
        {
            case "NE":
                transform.position += speed * transform.up * Time.deltaTime;
                transform.position += speed * transform.right * Time.deltaTime;
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
                transform.position += speed * transform.up * Time.deltaTime;
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
