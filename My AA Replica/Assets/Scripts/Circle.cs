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
        transform.Rotate(0f, 0f, (angularVelocity - additionalMassAngularVelocity * GravityMultiplayer) * Time.deltaTime); Debug.LogError(angularVelocity);
    }
}
