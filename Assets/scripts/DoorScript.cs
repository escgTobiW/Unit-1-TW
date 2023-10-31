using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject player;
    public GameObject[] door;
    
   Vector2 doorPos;

    bool open = false;

    void Start()
    {
       

    }

    void Update()
    {

        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        door = GameObject.FindGameObjectsWithTag("Door");
        doorPos = new Vector2(door.transform.position.x, door.transform.position.y);

        if (open == true)
        {
            if (sceneName == "Outside")
            {
                SceneManager.LoadScene("InsideHouse");
                player.transform.position = doorPos;
            }
            else if (sceneName == "InsideHouse")
            {
                SceneManager.LoadScene("Outside");
                player.transform.position = doorPos;
            }
           
            
        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey("e") == true)
            {
                open = true;
            }
        }

    }
}
