using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float velocity = 20f;
    public Rigidbody2D rb;

    void Update() 
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * velocity * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D (Collider2D collider) 
    {
        if(collider.tag == "circle")
        {
            transform.SetParent(collider.transform);
            isPinned = true;
        } else if(collider.tag == "pin") 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
