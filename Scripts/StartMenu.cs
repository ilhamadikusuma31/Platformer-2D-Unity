using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public GameObject credits;
    public GameObject optionMenu;
    public GameObject start;
    public GameObject levels;
    public GameObject[] levelDiOptionMenu;
    public static int level;

    public void Start()
    {
        level = PlayerPrefs.GetInt("levelTerbaik", 0); //ambil data di ID LevelTerbaik, kalo gada set 1 => ini bakal  buat load scene
    }
    public void PlayTheGame()
    {
        start.SetActive(false);
        optionMenu.SetActive(false);
        credits.SetActive(false);
        PlayerPrefs.DeleteKey("levelTerbaik"); //reset semua data ID levelTerbaik
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //masuk ke level0

    }

    public void LoadTheGame()
    {
        level = PlayerPrefs.GetInt("levelTerbaik", level);
        SceneManager.LoadScene(level+1);
    }
    public void showLevels()
    {
        start.SetActive(false);
        optionMenu.SetActive(true);
        levels.SetActive(true);
        credits.SetActive(false);
        level = PlayerPrefs.GetInt("levelTerbaik");
        for (int i = 0; i <= level; i++)
        {
            levelDiOptionMenu[i].SetActive(true);
        }

    }
    public void showOption()
    {
        start.SetActive(false);
        optionMenu.SetActive(true);
        levels.SetActive(false);
        credits.SetActive(false);

    }
    public void showCredits()
    {
        start.SetActive(false);
        optionMenu.SetActive(false);
        levels.SetActive(false);
        credits.SetActive(true);

    }
    public void closeCredits()
    {
        start.SetActive(false);
        optionMenu.SetActive(true);
        levels.SetActive(false);
        credits.SetActive(false);

    }
    public void closeLevels()
    {
        start.SetActive(false);
        optionMenu.SetActive(true);
        levels.SetActive(false);
        credits.SetActive(false);

    }
   

    public void Quit()
    {
        Application.Quit();
    }
}
