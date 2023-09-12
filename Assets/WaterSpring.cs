using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpring : MonoBehaviour
{
    private float velocity = 0;
    private float force = 0;
    private float height = 0f;
    private float target_height = 0f;

    public void WaveSpringUpdate(float springStiffness, float dampening)
    {
        height = transform.localPosition.y;

        var x = height - target_height;
        var loss = -dampening * velocity;

        force = -springStiffness * x;
        velocity += force;
        var y = transform.localPosition.y;
        transform.localPosition = new Vector3(transform.localPosition.x, y + velocity, transform.localPosition.z);
    }
   
}
