using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap : MonoBehaviour{
   
    public float upForce = 200f;

    private bool isDead = false;
    private Rigidbody2D rb2b;
    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2b = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2b.velocity = Vector2.zero;
                rb2b.AddForce(new Vector2(0, upForce));
                anim.SetTarget
            }  
        }      

        
    }
    void OnCollissionEnter2D ()
    {
        isDead = true;
    }
}
