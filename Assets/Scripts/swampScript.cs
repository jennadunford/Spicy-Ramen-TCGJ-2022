using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swampScript : MonoBehaviour
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
                storyText.text = "[You hear a mournful voice.]";
                break;
            case 1:
                storyText.text = "My name is Lila... I was the last protector of this world.";
                break;
            case 2:
                storyText.text = "Our elders... they created so much amazing technology... such wonderful power...";
                break;
            case 3:
                storyText.text = "I was decieved.";
                break;
            case 4:
                storyText.text = "They told me, as I tried to watch over this world that the sickness was coming from the common people... mundane acts.";
                break;
            case 5:
                storyText.text = "They said the machines were too pure and good to bring about disasters. I feel so foolish. And now we are nothing.";
                break;
            case 6:
                storyText.text = "Their technology is too powerful to destroy now... it will outlive us all.";
                break;
            case 7:
                storyText.text = "I will take the next Protector and put her in stasis until all these evil machines can be destroyed...";
                break;
            case 8:
                storyText.text = "Look at this world... look at our blight... so much pain... and we did nothing.";
                break;
            case 9:
                storyText.text = "Please Aurora... you are the hope. Free this planet. You are here to heal.";
                break;
            case 10:
                storyPanel.SetActive(false);
                break;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            lineCounter++;
        }
    }
}
