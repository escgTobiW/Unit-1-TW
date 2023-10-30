using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    Animator anim;
    float wait = 1;

    private SpriteRenderer spriteRenderer;


    public GameObject player;
    Vector2 playerPos;
    public GameObject enemy;
    Vector2 enemyPos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        wait+= Time.deltaTime;
        if (wait > 10)
        {

            playerPos = new Vector2(player.transform.position.x, transform.position.y);
            enemyPos = new Vector2(enemy.transform.position.x, transform.position.y);

            if (playerPos.x > enemyPos.x)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }

            transform.position = Vector2.MoveTowards(transform.position, playerPos, 3 * Time.deltaTime);

            anim.SetBool("enerun", true);

           


        }

    }
}
