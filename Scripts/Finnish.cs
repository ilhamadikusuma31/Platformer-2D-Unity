using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finnish : MonoBehaviour
{
    private AudioSource finnishsound;
   
    private void Start()
    {
        finnishsound = GetComponent<AudioSource>();
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            finnishsound.Play();
            Invoke("CompleteLevel", 2);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
