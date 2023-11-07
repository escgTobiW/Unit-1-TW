using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject player;
    //public GameObject door;

    //Vector2 doorPos;
    

    bool openable = false;
 

    void Start()
    {

     
    }

    void Update()
    {

        
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        //door = GameObject.Find("door");
       // doorPos = new Vector2(door.transform.position.x, door.transform.position.y);



        if ((openable == true) && (Input.GetMouseButton(1) == true))
        {
            if (sceneName == "Outside")
            {
                SceneManager.LoadScene("InsideHouse");
                /*door = GameObject.Find("door");
                doorPos = new Vector2(door.transform.position.x, door.transform.position.y);
                player.transform.position = doorPos;*/

          
               

            }
            else if (sceneName == "InsideHouse")
            {
                SceneManager.LoadScene("Outside");
               // door = GameObject.Find("door");
               // doorPos = new Vector2(door.transform.position.x, door.transform.position.y);
               // player.transform.position = doorPos;
                

            }

           
           
            
        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            openable = true;
        }
      

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            openable = false;
        }
      

    }
}
