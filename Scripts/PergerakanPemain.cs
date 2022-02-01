using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PergerakanPemain : MonoBehaviour
{
    Rigidbody2D rb_nya;
    Animator anim;
    SpriteRenderer sr;
    BoxCollider2D coll;

    //[SerializeField] typeData namaVar == public typeData namaVar
    //sama-sama bisa diatur di inspector
    //bedanya public bisa diakses script lain
    [SerializeField] float kecepatan = 10f;
    [SerializeField] float kekuatanLompat = 14f;
    [SerializeField] LayerMask tanahDipijak;
    
    [SerializeField] AudioSource lompatsound;


    //enum adalah class spesial yang bisa membuat var jadi int
    private enum SaatIni
    {
        idle,
        run,
        jump,
        fall,
    }
    //SaatIni s = SaatIni.idle; cara ngakses

    private float arahX = 0f;
    private void Start()
    {
        // dapetin komponen dari si player
        rb_nya = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
        

    }

    
    private void Update()
    {   
        // GetAxis => ada lerp nya, GetAxisRaw => kalo berhenti langsung 0
        // arahX   => bernilai 1 untuk kanan, -1 untuk kiri
        // x       => arahX * kec
        // y       => velocity.y saat ini

        arahX = Input.GetAxisRaw("Horizontal");
        rb_nya.velocity = new Vector2(arahX*kecepatan, rb_nya.velocity.y);

        if (Input.GetButtonDown("Jump") && DiTanahGa())
        {   
            // x => velocity.x saat ini
            // y => kekuatan jump-nya
            rb_nya.velocity = new Vector2(rb_nya.velocity.x,kekuatanLompat);
            lompatsound.Play();
        }
        
        updateAnimasi();

    }


    private void updateAnimasi()
    {
        SaatIni saat;

        if (arahX > 0f) 
        {
            saat = SaatIni.run;
            sr.flipX = false;
        }
        else if (arahX < 0f) 
        {
            saat = SaatIni.run;
            sr.flipX = true;
        }
        else
        {
            saat = SaatIni.idle;

        }

        if (rb_nya.velocity.y > 0.1f)
        {
            saat = SaatIni.jump;
        }
        else if (rb_nya.velocity.y < -0.1f)
        {
            saat = SaatIni.fall;
        }

        anim.SetInteger("State",(int)saat);
    }

    private bool DiTanahGa()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, tanahDipijak);
    }
}
