using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musuh : MonoBehaviour
{
    Animator anim;

    AudioSource musuhMatiSound;
    void Start()
    {
        anim = GetComponent<Animator>();
        musuhMatiSound = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            anim.SetTrigger("musuhUdahMati");
            musuhMatiSound.Play();
        }
    }
    public void destroyMusuh()
    {
        
        Destroy(this.gameObject);
    }
}
