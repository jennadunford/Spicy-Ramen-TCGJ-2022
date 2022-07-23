using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class templeScript : MonoBehaviour
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
                storyText.text = "[The large stone statue speaks to you]";
                break;
            case 1:
                storyText.text = "Who are you?";
                break;
            case 2:
                storyText.text = "I am here to heal, you reply, remembering the first words you heard.";
                break;
            case 3:
                storyText.text = "I have been told those words before... and it was a lie... I hope you will not lie to me too.";
                break;
            case 4:
                storyText.text = "I am the spirit of this planet... the soul of every living being is felt by me.";
                break;
            case 5:
                storyText.text = "I have seen so much sickness and sadness in this world.";
                break;
            case 6:
                storyText.text = "I wish only to rest.";
                break;
            case 7:
                storyPanel.SetActive(false);
                break;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            lineCounter++;
        }
    }
}
