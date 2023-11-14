using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor;
//using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

        
       
    public bool canMove = true;

    public GameObject player;

    public float speed;
    public float jump;

    bool dead = false;
    float wait = 1;

    /*
    public Sprite spriteDown;
    public Sprite spriteUp;
    public Sprite spriteLeft;
    public Sprite spriteRight;
    */


    private SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    Animator anim;


    Helping Helping;


    // Start is called before the first frame update
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        Helping = gameObject.AddComponent<Helping>();


    }


    // Update is called once per frame
    void Update()
    {
       


        

        if (canMove == true)
        {



            //-----Controls--------

            //---JUMP---         (was UP)
            if (Input.GetKeyDown("space") && (Helping.GroundCheck(0, 0)) == true)
            {
                //anim.SetBool("jump", true);
                rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);

                
            }
            /*
            if (Helping.GroundCheck(0, 0) == false)
            {
                anim.SetBool("jump", true);
            }
            else
            {
                anim.SetBool("jump", false);
            }
            */
            
            if (Input.GetKey("a") || Input.GetKey("d") == true)
            {


                if (Helping.GroundCheck(0, 0) == true)
                {
                    anim.SetBool("walk", true);
                }

                //---LEFT---
                if (Input.GetKey("a") == true)
                {
                    transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
                    spriteRenderer.flipX = true;
                }




                //---RIGHT--
                if (Input.GetKey("d") == true)
                {
                    transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
                    spriteRenderer.flipX = false;
                }
                


            }
         
            else
            {

                anim.SetBool("walk", false);

            }

            //----ATTACK---
            if (Input.GetKey("q") == true)
            {
                anim.SetBool("attack", true);
            }
            else
            {
                anim.SetBool("attack", false);
            }
            

        }
        //-----------------------

        if (dead == true)
        {
            wait += Time.deltaTime;

        }
        

        if (wait > 5)
        {
            SceneManager.LoadScene("Cutscene");
        }




    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            
            canMove = false;
            anim.SetBool("dead", true);
            //spriteRenderer.sprite = spriteDown;
            dead = true;
          

        }
       
    }
    
}

//---Holding-things----
/*
 
 
//---(from UP controls)---

  transform.position = new Vector2 (transform.position.x, transform.position.y + (speed * Time.deltaTime) );
  if (spriteRenderer.sprite != spriteUp)
                {
                    spriteRenderer.sprite = spriteUp;
                }

//----(from DOWN controls)---
    transform.position = new Vector2(transform.position.x, transform.position.y - (speed * Time.deltaTime));

    if (spriteRenderer.sprite != spriteDown)
                {
                    spriteRenderer.sprite = spriteDown;
                }

//----(from LEFT controls)---

if (spriteRenderer.sprite != spriteLeft)
                {
                    spriteRenderer.sprite = spriteLeft;
                }


//----(from RIGHT controls)---

     if (spriteRenderer.sprite != spriteRight)
                {
                        spriteRenderer.sprite = spriteRight;
                }



     //---FACE SCREEN---     (was DOWN)
            if (Input.GetKey("s") == true)
            {
                

            
            }



*/