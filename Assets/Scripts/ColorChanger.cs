using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // All in the one line we are:
            // - Getting the SpriteRender component which is attached to the GameObject that this script is attached to
            // - Accessing the Material object on that SpriteRendered (which is in a variable called material)
            // - Changing the color property (variable) of the material to red
            GetComponent<SpriteRenderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<SpriteRenderer>().material.color = Color.green;
        }

        // For the purpose of demonstration, I am write the following if statement slightly
        // different than the others
        if (Input.GetKeyDown(KeyCode.B) == true) // you don't have to put in the '==true' 
        {
            // Declare a variable that can hold a SpriteRenderer
            SpriteRenderer theSR;

            // Declare a variable that can hold a Material
            Material theMaterial;

            // Get the SpriteRenderer component off this game object and store it in
            // theSR variable
            theSR = GetComponent<SpriteRenderer>();

            // Get the Material object which is stored on the SpriteRendere in a variable
            // called material, and store it theMaterial variable  
            theMaterial = theSR.material;

            // Change the color property of the material to blue
            theMaterial.color = Color.blue;
        }
    }
}
