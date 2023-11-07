using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPatrol : MonoBehaviour
{

    Animator anim;
    public float speed;
    private SpriteRenderer spriteRenderer;

   

    bool flyDown = true;
    bool flyUp = false;

    public GameObject ghost;
    Vector2 ghostPos;

    void Start()
    {
        anim = GetComponent<Animator>();

        spriteRenderer = GetComponent<SpriteRenderer>();

      
    }



    void Update()
    {

        //anim.SetBool("walk", true);
        ghostPos = new Vector2(ghost.transform.position.x, ghost.transform.position.y);

        if (ghostPos.y < 5)
        {
            flyUp = true;
            flyDown = false;
        }


        if (ghostPos.y > 17)
        {
            flyUp = false;
            flyDown = true;
        }
     
      

      

        if ((flyDown == true) && (flyUp == false))
        {
            
            transform.position = new Vector2(transform.position.x , transform.position.y - (speed * Time.deltaTime));

        }

        if ((flyUp == true) && (flyDown == false))
        {
           
            transform.position = new Vector2(transform.position.x, transform.position.y + (speed * Time.deltaTime));

        }




    }




}

