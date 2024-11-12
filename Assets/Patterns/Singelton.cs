using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singelton : MonoBehaviour
{
    Goal winCon;
    public GameObject obj;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winCon = FindObjectOfType<Goal>();
        if (winCon != null)
        {
            Debug.Log("nothing missing not doing anything");
        }
        else
        {
            Debug.Log("something was missing");
            Instantiate(obj);
            
        }
    }
}
