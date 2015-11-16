using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{

    // Controllers
    private CoinScoreController csc;
    
    // GameObjects
    public GameObject player;

	void Start () 
    {
	
        csc = FindObjectOfType<CoinScoreController> ();

	}
	
    public void Win ()
    {

        Application.LoadLevel ("Win");

    }

    public void AddCoinScore ()
    {

        csc.AddCoin ();

    }

}
