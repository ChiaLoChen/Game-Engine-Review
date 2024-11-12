using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Observer obs;
    int points = 0;
    int highScore = 0;
    bool onVine = false;
    Rigidbody2D rigidbody;
    Points point;
  
    
    // Start is called before the first frame update
    void Start()
    {
        obs = FindObjectOfType<Observer>();
        rigidbody = GetComponent<Rigidbody2D>();
        point = FindObjectOfType<Points>();
    }

    

    // Update is called once per frame
    void Update()
    {
        Walk();
            
    }

    void Walk()
    {
       
           
            if (Input.GetKeyDown(KeyCode.D)) transform.position += Vector3.right;
            if (Input.GetKeyDown(KeyCode.A)) transform.position += Vector3.left;
        
            if (Input.GetKeyDown(KeyCode.W)) transform.position += Vector3.up;
            
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Banana")
        {
            points += 100;
            Debug.Log(points);
            Destroy(collision.gameObject);
        }
        else if(collision.tag == "Vine")
        {
            
            rigidbody.gravityScale = 0;
        }
        else if (collision.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
       



    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Vine")
        {
            
            rigidbody.gravityScale = 1;
        }
    }

    public int getPoints()
    {
        return points;
    }

   


}
