using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdyControl : MonoBehaviour
{
    public Transform tf;
    public Rigidbody2D rb;
    public bool IsJumping;
    public float time = 3.0f;

    // Use this for initialization
    public void Start ()
    {
        IsJumping = false;
    }
	
	// Update is called once per frame
	public void FixedUpdate ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 400);
        }
	}

    IEnumerator Wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}