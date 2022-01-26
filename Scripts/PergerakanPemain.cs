using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PergerakanPemain : MonoBehaviour
{   
    Rigidbody2D rb_nya;
    private void Start()
    {
        rb_nya = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {   
        // GetAxis => ada lerp nya, GetAxisRaw => kalo berhenti langsung 0
        // arahX   => bernilai 1 untuk kanan, -1 untuk kiri
        // x       => arahX * kec
        // y       => velocity.y saat ini

        float arahX = Input.GetAxisRaw("Horizontal");
        rb_nya.velocity = new Vector2(arahX*10f, rb_nya.velocity.y);



        if (Input.GetButtonDown("Jump"))
        {   
            // x => velocity.x saat ini
            // y => kekuatan jump-nya
            rb_nya.velocity = new Vector2(rb_nya.velocity.x,10f);
        }  
    }
}
