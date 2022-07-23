using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forestScript : MonoBehaviour
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
                storyText.text = "After so many years... nature has healed so gracefuly. There is so much beauty, but the scars left by my people are still here";
                break;
            case 1:
                storyText.text = "I must do what I can to heal. I must protect this place.";
                break;

            case 2:
                storyPanel.SetActive(false);
                break;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            lineCounter++;
        }
    }
}
