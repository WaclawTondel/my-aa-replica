using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float angularVelocity;
    public float additionalMassAngularVelocity;
    public static List<Pin> pins = new List<Pin>();

    void Update() 
    {
        float GravityMultiplayer = 0;
        foreach(Pin pin in pins)
        {
                GravityMultiplayer += pin.CalculatePinGravityMultiplayer();
        }
        Debug.LogError(GravityMultiplayer);
        ;
        ;
        transform.Rotate(0f, 0f, this.CalculateSpeed(GravityMultiplayer) * Time.deltaTime); 
    }

    private float CalculateSpeed (float GravityMultiplayer)
    {
        float speed = (angularVelocity - additionalMassAngularVelocity * GravityMultiplayer);
        if (speed < 10)
        {
            speed = 10;
        }
        return speed;
    }
}
