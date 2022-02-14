using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject panelPause;
    public void FixedUpdate()
    {
        if (Input.GetButtonDown("Cancel")){
            Time.timeScale = 0;
            panelPause.SetActive(true);
        } 
    }
    
    public void Unpause()
    {
        Time.timeScale = 1;
        panelPause.SetActive(false);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        panelPause.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void Quit()
    {
        Time.timeScale = 1;
        panelPause.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
