using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float velocity = 20f;
    public Rigidbody2D rb;
    public float mass;

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
            Goal.PinsLeft--;
            isPinned = true;
            Circle.pins.Add(this);
            if (Goal.PinsLeft == 0)
            {
                FindObjectOfType<GameManager>().WinGame();
            }
        } else if(collider.tag == "pin") 
        {
            FindObjectOfType<GameManager>().EndGame();
        } else if(collider.tag == "ring")
        {
            transform.SetParent(collider.transform);
            isPinned = true;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    public float CalculatePinGravityMultiplayer()
    {
        return (Mathf.Sin(GetPinRotationInRadians())) * this.mass;
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
