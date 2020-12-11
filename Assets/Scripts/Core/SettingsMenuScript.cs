using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SettingsMenuScript : MonoBehaviour
{

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

    public void LanguageChanged(int language)
    {
        Debug.Log("AAAAAAAA: " + language);
        if (language == 0)
        {
            TextLocalization.CurrentLanguage = "english";
        }
        else if (language == 1)
        {
            TextLocalization.CurrentLanguage = "german";
        }

        

        Debug.Log("BBBBBBBB: " + TextLocalization.CurrentLanguage);

    }
}
