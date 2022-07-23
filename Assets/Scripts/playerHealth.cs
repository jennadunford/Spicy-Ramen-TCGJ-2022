using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float pHealth = 3f;
    public Transform respawnPoint;

    //set player health to 3 at start
    //player health decreased by 1 for each hit by an enemy
    //player respawns at start of current level if runs out of health

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(pHealth <= 0)
        {
            transform.position = respawnPoint.position;
            pHealth = 3;
        }
        
    }
}
