using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Declare a variable called thePosition of type Vector3
        Vector3 thePosition;

        // Get the position property (which is a Vector3) of the Transform component, that is attached to the same GameObject
        // as this script, and which is stored in a variable called transform, and save it to thePosition variable
        thePosition = transform.position;

        // Add 0.01 to the x property of thePosition
        thePosition.x = thePosition.x + 0.01f;

        // Set the position property of the transform to (the now modified) thePosition variable
        transform.position = thePosition;
    }
}
