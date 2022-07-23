using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class outlookStoryScrit : MonoBehaviour
{
    // Start is called before the first frame update
    int lineCounter = 0;
    public Text storyText;
    public GameObject storyPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() { 
    
        switch (lineCounter)
        {
            case 0:
                storyText.text = "[You hear a humming voice]";
                break;
            case 1:
                storyText.text = "We were a great and powerful civilization.We had such advanced machinery and technology - our lives were made so rich."
;
                break;
            case 2:
                storyText.text = "Everyone was so prosperous... and our Protector... they told us everything was fine... we did not see...";
                break;
            case 3:
                storyText.text = "...";
                break;
            case 4:
                storyText.text = "What happened to such a great people? Why is everything in ruins if they were so powerful?";
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

