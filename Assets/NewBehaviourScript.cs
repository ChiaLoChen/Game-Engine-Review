using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject player;
    private bool isGravity = true;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void Gravity()
    {
        if (isGravity)
        {
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
            isGravity = false;
        }
        else
        {
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            isGravity = true;
        }
    }
}
