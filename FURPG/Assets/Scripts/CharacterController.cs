using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f;
    public float SprintSpeed = 10f;
    

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

        if (Input.GetAxis("Jump") > 0){
            Sprinting();
        }
        else{
            Walking();
        }

    }
    
    public void Walking()
    {
          
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        
       
    }

    public void Sprinting()
    {
        rb.MovePosition(rb.position + movement * SprintSpeed * Time.fixedDeltaTime);
    }
}
