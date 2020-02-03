using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float angularVelocity = 100f;
    public float additionalMassAngularVelocity = 10f;
    public static List<Pin> pins = new List<Pin>();

    void Update() 
    {
        float GravityMultiplayer = 0;
        foreach(Pin pin in pins)
        {
                GravityMultiplayer += pin.CalculatePinGravityMultiplayer();
        }
        angularVelocity -= additionalMassAngularVelocity * GravityMultiplayer * Time.deltaTime;
        transform.Rotate(0f, 0f, (angularVelocity) * Time.deltaTime);
    }
}
