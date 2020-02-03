using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float velocity = 20f;
    public Rigidbody2D rb;

    private float TimeMultiplayer = 0;

    void Update() 
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * velocity * Time.deltaTime);
        }else if (TimeMultiplayer < 1)
        {
            TimeMultiplayer += Time.deltaTime / 5;
        }else
        {
            TimeMultiplayer = 1;
        }
    }

    void OnTriggerEnter2D (Collider2D collider) 
    {
        if(collider.tag == "circle")
        {
            transform.SetParent(collider.transform);
            isPinned = true;
            Circle.pins.Add(this);
        } else if(collider.tag == "pin") 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    public float CalculatePinGravityMultiplayer()
    {
        return (Mathf.Cos(GetPinRotationInRadians())) * TimeMultiplayer;
    }

    private float GetPinRotation()
    {
        return this.transform.rotation.eulerAngles.z;
    }
    private float GetPinRotationInRadians()
    {
        return (this.GetPinRotation() * Mathf.PI) / 180f;
    }
}
