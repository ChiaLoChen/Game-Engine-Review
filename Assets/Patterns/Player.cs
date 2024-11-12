using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Observer obs;
    int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        obs = FindObjectOfType<Observer>();
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
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        points += 100;
        Debug.Log(points);
    }

    public int getPoints()
    {
        return points;
    }


}
