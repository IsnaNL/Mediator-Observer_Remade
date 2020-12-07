using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 velocity;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        if(horInput != 0 || verInput != 0)
        {
            velocity = new Vector3(horInput * speed, 0, verInput * speed);
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(velocity * Time.fixedDeltaTime);
    }
   
}
