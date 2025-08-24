using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Levels : MonoBehaviour
{
    public Button[] buttons;

    private void Awake()
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel1", 1);
        for (int i = 0; i <buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void loadlevel1()
    {

        SceneManager.LoadSceneAsync(1);
    }

    public void loadlevel2()
    {

        SceneManager.LoadSceneAsync(2);
    }

    public void loadlevel3()
    {

        SceneManager.LoadSceneAsync(3);
    }

    public void loadlevel4()
    {

        SceneManager.LoadSceneAsync(4);
    }
    public void loadlevel5()
    {

        SceneManager.LoadSceneAsync(5);
    }
}
