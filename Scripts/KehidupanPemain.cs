using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KehidupanPemain : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] AudioSource MatiSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("jebakan"))
        {
            mati();
        }
    }

    private void mati()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("udahMati");
        MatiSound.Play();
    }

    public void restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
