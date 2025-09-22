using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 0.0f;
    public float jumpHeight = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            movement.y += jumpHeight;
                
        }
        
        transform.Translate(movement * speed * Time.deltaTime);

    }

}
