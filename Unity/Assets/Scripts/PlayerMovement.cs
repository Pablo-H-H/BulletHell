using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float lentoSpeed;

    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * lentoSpeed * forwardInput);
            transform.Translate(Vector3.right * Time.deltaTime * lentoSpeed * horizontalInput);
        } else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }

    }
}
