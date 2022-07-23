using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Transform target;
    public float minimumDistance;

    public GameObject playerObject;

    public Transform attackPoint;
    public float attackRange = 0.3f;
    public LayerMask heroLayer;

    public float forcePush;

    public bool facingRight = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        //Enemy should check if there is a shadow
        //If shadow exists change target
        if (Vector2.Distance(transform.position, target.position) < minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (playerObject.transform.position.x > gameObject.transform.position.x)
        {
            gameObject.transform.localScale = new Vector3(-0.3f, 0.3f, 1f);
            facingRight = false;
        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
            facingRight = true;
          
        }

        //if player not attacking and touching player - player take damage
        //attack point will be touching layer

       

    }
    private void FixedUpdate()
    {
        if (!playerObject.GetComponent<playerCombat>().playerAttacking)
        {
            Attack();
            //need to push player back to prevent infinite attack
        }
        
    }

    void Attack()
    {
        //play enemy hit animation
        //enemyAnimator.SetTrigger("Hit");

        //Detect enemy in range of attack
        Collider2D[] punchHero = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, heroLayer);  //the array will detect when the player appears within the assigned range

        //Damage Enemy
        foreach (Collider2D hero in punchHero)
        {
            
            //hero.GetComponent<playerHealth>().takeDamage(attackDamage);     //calls the playerHealth script to decrease player health

            //Push the player in opposite direction
            //Debug.Log("Movehori value: " + playerObject.GetComponent<playerMovement>().moveHori);
            if (facingRight)
            {
                //push left
               // Debug.Log("push left");
               // playerObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1,0);

               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(15f , 0f), ForceMode2D.Impulse);
            }
            else
            {
                //push right
               // Debug.Log("push right");
                //playerObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-15f , 0), ForceMode2D.Impulse);
            }
            Debug.Log("punched hero" + hero.name);
            break;
        }



    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)       //used to ensure no error is thrown when nothing is within the punchPoint range
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);    //visually display the overlapcircle in unity game scene
    }

}
