using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Points : MonoBehaviour
{
    public Text text;
    Player player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        text.text = player.getPoints().ToString();
    }

    
    public void changeScore()
    {
        text.text = player.getPoints().ToString();
    }

    
}
