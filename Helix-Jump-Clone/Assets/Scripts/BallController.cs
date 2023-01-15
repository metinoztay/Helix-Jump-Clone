using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
   [SerializeField] private Rigidbody myRigidbody;
   [SerializeField] private float velocityLimit;

    private void FixedUpdate()
    {
        var vertical = myRigidbody.velocity;
        vertical.y = Mathf.Clamp(vertical.y, -velocityLimit, +velocityLimit);
        myRigidbody.velocity = vertical;

    }
}
