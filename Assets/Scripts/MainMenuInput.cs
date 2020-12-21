using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuInput : MonoBehaviour
{
    private bool showingTutorial = false;
    public Text txtBox;
    [TextArea]
    public string tutorialText;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnRestart()
    {
        if (!showingTutorial)
        {
            showingTutorial = true;
            txtBox.text = tutorialText;
        }
        else
        {
            SceneManager.LoadScene("level1");

        }

    }
}
