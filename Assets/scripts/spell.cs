using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{


    
    public GameObject player;
    Vector2 playerPos;
   

    bool On = true;
   


   

    void Start()
    {
  
    }

  
    void Update()
    {



        if (Input.GetMouseButtonDown(1) == true)
        {
            On = !On;
        }

        if (On == true)
        {
            playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, playerPos, 4 * Time.deltaTime);
        }




    }
}
