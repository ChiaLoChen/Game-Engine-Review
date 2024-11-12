using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Observer : MonoBehaviour
{
    Player player;
    int pointHolder = 0;
   
    public Points[] pointArray;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Observe()
    {
        if(player.getPoints() != pointHolder)
        {
            //update the UI
            for(int i = 0; i <= pointArray.Length; i = i + 1)
            {
                pointArray[i].changeScore();
            }
            
            pointHolder = player.getPoints();
        }
    }
}
