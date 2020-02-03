using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public static float angularVelocity = 100f;
    public static float additionalMassAngularVelocity = 60f;
    public static List<Pin> pins = new List<Pin>();

    void Update() 
    {
        float GravityMultiplayer = 0;
        foreach(Pin pin in pins)
        {
                GravityMultiplayer += pin.CalculatePinGravityMultiplayer();
        }
        transform.Rotate(0f, 0f, (angularVelocity + additionalMassAngularVelocity * GravityMultiplayer) * Time.deltaTime);
        Debug.LogWarning(GravityMultiplayer);
        Debug.LogWarning(angularVelocity + additionalMassAngularVelocity * GravityMultiplayer);
    }
}
