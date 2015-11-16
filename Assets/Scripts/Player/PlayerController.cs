using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour 
{

	public float moveSpeed      = 15f;
    public float jumpHeight     = 1000f;

    private Animator animator;
    private bool isAirborne;

    void Start ()
    {

        isAirborne = false;
        animator = GetComponent<Animator> ();

    }

    void OnCollisionEnter2D ()
    {

        isAirborne = false;

    }

    void OnCollisionExit2D ()
    {

        isAirborne = true;

    }

    private void waitAndDie ()
    {

        DateTime dt = DateTime.Now + TimeSpan.FromSeconds (1);

        do { } while (DateTime.Now < dt);

        Debug.Log ("DED");

        transform.position = new Vector2 (0, 0);
        FindObjectOfType<CoinScoreController> ().SetCoinScore (0);

    }

    public void die ()
    {

        Debug.Log ("I died :(");
        waitAndDie ();
        

    }

	private void Update ()
	{

        // Check if player has fallen
        if (transform.position.y < -70)
        {

            die ();

        }

        if ( ! Input.anyKey)
        {

            if (isAirborne)
            {

                animator.Play ("airborne");

            }
            else
            {

                animator.Play ("idle");

            }

        }
        else
        {

            controls ();

        }

	}

    private void controls ()
    {

        if (Input.GetAxisRaw ("Horizontal") != 0)
        {

            if (!isAirborne && Input.GetAxisRaw ("Horizontal") > 0 && !animator.GetCurrentAnimatorStateInfo (0).IsName ("walkRight"))
            {

                animator.Play ("walkRight");

            }
            else if (!isAirborne && Input.GetAxisRaw ("Horizontal") < 0 && !animator.GetCurrentAnimatorStateInfo (0).IsName ("walkLeft"))
            {

                animator.Play ("walkLeft");

            }

            this.GetComponent<Transform> ().Translate (new Vector2 ((Input.GetAxisRaw ("Horizontal") * moveSpeed) * Time.deltaTime, 0));

        }

        if (Input.GetKeyDown ("up") && !isAirborne)
        {

            this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpHeight));
            animator.Play ("airborne");

        }

    }

}
