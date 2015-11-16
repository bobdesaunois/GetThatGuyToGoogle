using UnityEngine;
using System.Collections;

public class BobsHouseDoor : MonoBehaviour 
{

    void OnTriggerEnter2D ()
    {

        FindObjectOfType<GameController> ().Win ();

    }

}
