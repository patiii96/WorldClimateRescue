using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // START MENU BUTTONS
    public void StartGameButtonClick()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void SelectLevelButtonClick()
    {
        SceneManager.LoadScene("SelectLevelScene");
    }

    public void SettingsButtonClick()
    {

    }

    public void ExitGameButtonClick()
    {
        Application.Quit();
    }

}
