using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{

    Animator anim;
    public float speed;
    private SpriteRenderer spriteRenderer;

    Helping Helping;

    bool flyLeft = false;
    bool flyRight = true;
   

    
    void Start()
    {
        anim = GetComponent<Animator>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        Helping = gameObject.AddComponent<Helping>();
    }

   
    void Update()
    {
        anim.SetBool("fly", true);

        if (Helping.WallCheckLeft(-0.15f, 0.05f) == true)
        {
            flyLeft = false;
            flyRight = true;
        }

        if (Helping.WallCheckRight(0.15f, 0.05f) == true)
        {
            flyRight = false;
            flyLeft = true;
     
        }


        if ((flyLeft == true) && (flyRight == false))
        {
            spriteRenderer.flipX = true;
            transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);

        }

        if ((flyRight == true) && (flyLeft == false))
        {
            spriteRenderer.flipX = false;
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);

        }





    }
}
