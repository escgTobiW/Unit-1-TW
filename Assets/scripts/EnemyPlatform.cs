using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlatform : MonoBehaviour
{

    Animator anim;
    public float speed;
    private SpriteRenderer spriteRenderer;

    Helping Helping;

    bool walkLeft = true;
    bool walkRight = false;



    void Start()
    {
        anim = GetComponent<Animator>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        Helping = gameObject.AddComponent<Helping>();
    }



    void Update()
    {

        anim.SetBool("walk", true);

        if (Helping.GroundCheck(-0.15f, 0) == false)
        {
            walkRight = true;
            walkLeft = false;
        }

        if (Helping.GroundCheck(0.15f, 0) == false)
        {
            walkLeft = true;
            walkRight = false;
        }
      

      

        if ((walkLeft == true) && (walkRight == false))
        {
            spriteRenderer.flipX = false;
            transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);

        }

        if ((walkRight == true) && (walkLeft == false))
        {
            spriteRenderer.flipX = true;
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);

        }




    }




}

