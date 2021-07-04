using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public bool isDead;
    
    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public GameManager managerGame;


    void Update ()
    {
        //tıklama alma
        if (Input.GetMouseButtonDown(0))
        {
            //havada kuşun sıçraması
            rb2D.velocity = Vector2.up*velocity;
        
            
        }
    
    }   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")

        {
            managerGame.UpdateScore();
            

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "DeathArea")
        isDead = true;
        Time.timeScale=0;
        
    }

    
  }

