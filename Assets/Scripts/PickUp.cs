using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float minY; // Minimum height
    public float maxY; // Maximum height
    public float levitationSpeed; // Speed of levitation

    private bool movingUp = true;

    void Start()
    {
        // Initialize currentHeight with a random value between minHeight and maxHeight
        float initialHeight = Random.Range(minY, maxY);
        transform.position = new Vector3(transform.position.x, initialHeight, transform.position.z);


    }

    void Update()
    {
        //transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        // Calculate the new position
        Vector3 newPosition = transform.position;

        // Check if we need to move up or down
        if (movingUp)
        {
            newPosition.y += levitationSpeed * Time.deltaTime;
            if (newPosition.y >= maxY)
                movingUp = false;
        }
        else
        {
            newPosition.y -= levitationSpeed * Time.deltaTime;
            if (newPosition.y <= minY)
                movingUp = true;
        }

        // Apply the new position
        transform.position = newPosition;
    }

}
