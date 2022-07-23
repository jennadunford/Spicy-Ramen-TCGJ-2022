using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wastelandScript : MonoBehaviour
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
                storyText.text = "There came a time of great despair. So many natural disasters...";
                break;
            case 1:
                storyText.text = "Our crops began to fail as the soil grew sick. The water was not fit to drink.";
                break;
            case 2:
                storyText.text = "We once had everything we needed from nature - it seemed as if the very planet was turning against us... killing us.";
                break;
            case 3:
                storyText.text = "And still... the protector told us it was all fine...";
                break;
            case 4:
                storyText.text = "The propaganda... the lies... the distractions...";
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

