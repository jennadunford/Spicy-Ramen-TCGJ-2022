using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour
{

    public Animator playerAnimator;

    //public Transform punchPoint;
    //public float punchRange = 0.3f;
    //public LayerMask enemyLayer;                         //using a layermask and assigned layers to detect the enemy

    //public int attackDamage = 15;

    public static int numPresses = 0; //changed from public to public static so that numpresses can be accessed by movement script
    //float lastTimePressed = 0;
    public float maxAttackDelayTime = 1.2f;

    public float attackRate = 2f;
    private float nextAttackTime = 0f;

    public  bool playerAttacking;
 
    public Transform attackPoint;
    public float attackRange = 0.3f;
    public LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerAttacking = Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayer);
        /*if (Time.time - lastTimePressed > maxAttackDelayTime)
        {
            numPresses = 0;
        }*/

        if (Time.time >= nextAttackTime)
        {
            if ((Input.GetKeyDown(KeyCode.E)))
            {
                /*lastTimePressed = Time.time;
                numPresses++;*/


                /*if (numPresses == 1)
                {
                    //Punch();
                    //attackDamage = 1;
                    playerAnimator.SetTrigger("Attack");//new line of code//THIS WORKED!
                    Debug.Log("player attacked");

                    //Punch();
                }*/


                //numPresses = Mathf.Clamp(numPresses, 0, 1);

                playerAnimator.SetTrigger("Attack");//new line of code//THIS WORKED!
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
                Debug.Log("player attacked");

            }
        }


        /*if ((Input.GetKeyDown(KeyCode.E)))
        {
            lastTimePressed = Time.time;
            numPresses++;
            

            if (numPresses == 1)
            {
                //Punch();
                //attackDamage = 1;
                playerAnimator.SetTrigger("Attack");//new line of code//THIS WORKED!
                Debug.Log("player attacked");
                
                //Punch();
            }
            

            numPresses = Mathf.Clamp(numPresses, 0, 1);


        }*/

    }

    void Attack()
    {
        //play the punch animation
        //playerAnimator.SetTrigger("Punch");

        //play player punch sound
        //FindObjectOfType<AudioManager>().Play("playerGrunt");

        //Detect enemy in range of attack
        Collider2D[] punchEnemy = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);       //the array will detect any enemies that appear within the assigned range
                                                                                                                 //of the overlapcircle 
                                                                                                                 //Damage Enemy
        foreach (Collider2D enemy in punchEnemy)
        {
            Debug.Log("punched enemy" + enemy.name);
            //enemy.GetComponent<enemyHealth>().takeDamage(attackDamage);        //calls the enemyHealth script to decrease the health of the enemy
       
        }

    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)               //used to ensure no error is thrown when nothing is within the punchPoint range
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange); //visually display the overlapcircle in unity game scene
    }

}
