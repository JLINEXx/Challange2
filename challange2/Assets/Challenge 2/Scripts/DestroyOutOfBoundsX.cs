using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = 30f; // Right boundary limit (x-axis)
    private float bottomLimit = -5f; // Bottom boundary limit (y-axis)

    // Update is called once per frame
    void Update()
    {
        // Destroy object if it moves beyond the left limit on the x-axis
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy object if it moves below the bottom limit on the y-axis
        else if (transform.position.y < bottomLimit) // Changed to y-axis
        {
            Destroy(gameObject);
        }
    }
}
