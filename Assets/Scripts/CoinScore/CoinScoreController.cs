using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinScoreController : MonoBehaviour 
{

    public Text text;
    
    private int coinScore;

    void start ()
    {

        coinScore = 0;

    }

    public void SetCoinScore (int newCoinScore)
    {

        coinScore = newCoinScore;
        UpdateScore ();

    }

    public void AddCoin ()
    {

        coinScore++;
        UpdateScore ();

    }

	private void UpdateScore ()
    {

        if (coinScore < 10)
            text.text = "0" + coinScore;
        else
            text.text = "" + coinScore;

    }

}
