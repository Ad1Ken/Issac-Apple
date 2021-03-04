using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionOnTiles : MonoBehaviour
{

    public SpriteRenderer color;
    public int scoreValue=1;
   // public int scoreValue = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            color.color = Color.black;
            FindObjectOfType<ScoreScript>().ScoreUpdate(scoreValue);
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(color.color==Color.black)
        {
            Debug.Log("u r fine");
        }
        else if (col.collider.tag == "Border") 
        {
            FindObjectOfType<HUDHandler>().ActiveGameState(HUDstate.GameOver);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
