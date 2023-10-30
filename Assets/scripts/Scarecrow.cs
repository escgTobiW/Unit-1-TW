using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Scarecrow : MonoBehaviour
{

    Helping Helping;

    public GameObject player;
    Vector2 playerPos;
    public GameObject scarecrow;
    Vector2 scarecrowPos;


    // Start is called before the first frame update
    void Start()
    {
        Helping = gameObject.AddComponent<Helping>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if( Input.GetKey("space"))
        {
            Helping.FlipObject(true);

        }
        */
        playerPos = new Vector2(player.transform.position.x, transform.position.y);
        scarecrowPos = new Vector2(scarecrow.transform.position.x, transform.position.y);

        if (playerPos.x > scarecrowPos.x)
        {
            Helping.FlipObject(true);
        }
        else
        {
            Helping.FlipObject(false);
        }


    }
}



