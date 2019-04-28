using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 0.1f;
    public float Jumpheigth = 1f;

  
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0)
        {
            transform.position += transform.right * Speed;
        }
        if (horizontal < 0)
        {
            transform.position += -transform.right * Speed;
        }
       
        
        if (vertical > 0)
        {
          transform.position += transform.up * Speed * Jumpheigth;
               
        }
           
                     
        
        if (vertical < 0)
        {
            transform.position += -transform.up * Speed;
        }
    }
}
