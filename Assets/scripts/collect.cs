using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class collect : MonoBehaviour
{
    float wait;
    bool hit;

    // Start is called before the first frame update
    void Start()
    {
        hit = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckForHit();
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hit = true;
            wait = 0.2f;
        }
     
    }

    void CheckForHit()
    { 
        if (hit)
        { 
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.01f);

            wait-=Time.deltaTime;

            if( wait < 0 )
            {
                Destroy(gameObject);
            }
        }
    }
     
      
    


}
