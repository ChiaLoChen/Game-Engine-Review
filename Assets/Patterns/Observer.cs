using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Observer : MonoBehaviour
{
    Player player;
    int pointHolder = 0;
    public Text highscoretext;
    int highscore = 0;
    public Points[] pointArray;
    // Start is called before the first frame update
    void Start()
    {

        player = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        Observe();
        SetHighScore();
       
    }

    public void Observe()
    {
        if(player.getPoints() != pointHolder)
        {
            //update the UI
            for(int i = 0; i < pointArray.Length; i = i + 1)
            {
                pointArray[i].changeScore();
                Debug.Log("print");
            }
            
            pointHolder = player.getPoints();
        }
    }

    void SetHighScore()
    {
        if (player.getPoints() > highscore)
        {
            highscore = player.getPoints();
            highscoretext.text = highscore.ToString();
        }
    }

    public void Victory()
    {
        highscoretext.text = "You win";
    }
   
}
