using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatScript : MonoBehaviour {

    public AudioSource eatSound;


    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("omg!");
        
        if (collision.gameObject.CompareTag("HotDogBite"))
        { 
            eatSound.Play();
            collision.gameObject.SetActive(false);
        }
    }
}
