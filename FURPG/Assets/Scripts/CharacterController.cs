using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f;
    public float sprintSpeed = 15f;

    public bool IsSprinting = false;

    public Rigidbody2D rb;
    Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxisRaw("Horizontal");

        Input.GetAxisRaw("Vertical");
        

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetAxisRaw("Jump") > 0)
        {
            IsSprinting = true;
        }
        else
        {
            IsSprinting = false;
        }
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * (IsSprinting ? sprintSpeed : speed) * Time.fixedDeltaTime);
    }
}
