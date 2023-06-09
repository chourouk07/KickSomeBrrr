using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float speed = 2f; // The speed at which the platform moves
    private float maxHeight ; // The maximum height the platform can reach
    private float minHeight ; // The minimum height the platform can reach
    [SerializeField] private float addHeight = 10.0f;


    private bool goingUp = true; // Flag to indicate if the platform is moving up or down
    
    void Start()
    {
        minHeight = transform.position.y ;
        maxHeight = minHeight + addHeight;
    }
    // Update is called once per frame
    void Update()
    {
        // Move the platform up or down depending on the flag
        if (goingUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            // Check if the platform has reached the maximum height, and switch the flag if true
            if (transform.position.y >= maxHeight)
            {
                goingUp = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            // Check if the platform has reached the minimum height, and switch the flag if true
            if (transform.position.y <= minHeight)
            {
                goingUp = true;
            }
        }
    }
}
