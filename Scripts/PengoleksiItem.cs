using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PengoleksiItem : MonoBehaviour
{
    int apple = 0;
    [SerializeField] Text TextApel;
    [SerializeField] AudioSource AppleSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            apple++;

            TextApel.text = "Apple :" + apple ;
            AppleSound.Play();
        }
    }
}
