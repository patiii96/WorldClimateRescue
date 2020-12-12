using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class SettingsMenuScript : MonoBehaviour
{
    int levelToChoose = -1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioToggleClicked(bool isOn)
    {
       AudioListener.volume = Convert.ToInt32(isOn);
    }

    public void AudioSliderChanged(float value)
    {
        AudioListener.volume = value;
    }


    // MAIN MENU SETTINGS BUTTONS
    public void QuitLevelButtonClick()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void ChooseLevel(int level)
    {
        switch (level)
        {
            case 1:
                SceneManager.LoadScene("FirstLevel");
                break;
            case 2:
                SceneManager.LoadScene("");
                break;
            case 3:
                SceneManager.LoadScene("");
                break;
            case 4:
                SceneManager.LoadScene("");
                break;
            case 5:
                SceneManager.LoadScene("");
                break;
            case 6:
                SceneManager.LoadScene("");
                break;
            case 7:
                SceneManager.LoadScene("");
                break;
            case 8:
                SceneManager.LoadScene("");
                break;
            default:
                break;
        }
    }

    public void StartScreenButtonClick()
    {
        SceneManager.LoadScene("StartScene");
    }
}
