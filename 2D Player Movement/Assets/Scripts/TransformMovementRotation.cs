using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovementRotation : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 20; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.back, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
