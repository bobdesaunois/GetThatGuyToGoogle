using UnityEngine;
using System.Collections;

public class DeathOnTouch : MonoBehaviour 
{

    private GameObject collided;

    void OnTriggerEnter2D (Collider2D collider)
    {

        if (collider.name == "Player")
            FindObjectOfType<PlayerController> ().die ();

    }
	
}
