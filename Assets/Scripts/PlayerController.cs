using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 movement;
    public Transform worldRef;

    public float speed;
    public float maxSpeed = 20f;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 horizontalVector = worldRef.right * (horizontal * speed);
        Vector3 verticalVector = worldRef.forward * (vertical * speed);
        
        movement = verticalVector + horizontalVector;
        
        rb.AddForce(movement.normalized * speed);
        Vector3 velocity = rb.linearVelocity;
        velocity.x = Mathf.Clamp(velocity.x, -maxSpeed, maxSpeed);
        velocity.z = Mathf.Clamp(velocity.z, -maxSpeed, maxSpeed);
        rb.linearVelocity = velocity;
    }
    
}
