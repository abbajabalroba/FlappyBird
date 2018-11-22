using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoving : MonoBehaviour
{
    public GameObject pipes;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        rb.AddForce(-Vector2.right * 4000);
    }
}
