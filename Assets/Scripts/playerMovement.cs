using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    GameObject gameObject;
    Rigidbody rb;

    [SerializeField] private int moveSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);


        //rb.velocity = (new Vector3(rb.velocity.x+horizontalInput, rb.velocity.y, rb.velocity.z+verticalInput) * moveSpeed * Time.deltaTime);
    }
}
