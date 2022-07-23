using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baseStoryScript : MonoBehaviour
{
    int lineCounter = 0;
    public Text storyText;
    public GameObject storyPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (lineCounter)
        {
            case 0:
                storyText.text = "You are here to heal...";
                break;
            case 1:
                storyText.text = "[A Mechanical, yet, Ethereal voice speaks.] Aurora. You have awoken. It has been thousands of years... do you remember anything?";
                break;
            case 2:
                storyText.text = "No? So much has changed... your planet has missed her protector.";
                break;
            case 3:
                storyText.text = "I am the Guardian of all this beautiful technology... I have been keeping it safe for you...";
                break;
            case 4:
                storyText.text = "Go and explore your world.";
                break;
            case 5:
                storyPanel.SetActive(false);
                break;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            lineCounter++;
        }
        
    }
}
