using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSelectLevel : MonoBehaviour
{
    public int levelKe;

    public void enterLevel()
    {
        SceneManager.LoadScene(levelKe+1);
    }
}
