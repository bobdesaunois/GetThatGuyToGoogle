using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour 
{

    private GameController gc;

    void Start ()
    {

        gc = FindObjectOfType<GameController> ();
        Debug.Log (gc);

    }

	void OnTriggerEnter2D ()
    {

        Debug.Log ("COIN HAS BEEN HAD");
        gc.AddCoinScore ();
        DestroyObject (gameObject);

    }

}
