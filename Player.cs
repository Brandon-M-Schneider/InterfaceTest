using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ColorChange, Movement // Inherits parent interfaces.
{
    public Color RandomColors { get; set; } // Inherited property

    public void Update()
    {
        // Changes object to a random RGB color of 3 random floats
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomColors = new Color(RandomNumber(), RandomNumber(), RandomNumber());
            ChangeColor(RandomColors);
        }

        // Upward movement functionality
        if (Input.GetKey(KeyCode.UpArrow))
        {
            UpwardMovement();
        }

        // Downward movement functionality
        if (Input.GetKey(KeyCode.DownArrow))
        {
            DownwardMovement();
        }
    }

    // Grabs renderer object component, assigns color to a parameter
    public void ChangeColor(Color rColor)
    {
        GetComponent<Renderer>().material.color = rColor;
    }

    // Returns a float between 0 and 1.
    public float RandomNumber()
    {
        float x = Random.Range(0f, 1f);
        Debug.Log(x);
        return x;
    }

    // Move the object 1m/sec upward if object on y axis is less than 5
    public void UpwardMovement()
    {
        if (this.transform.position.y >= 5)
        {
            return;
        }
        else
        {
            this.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }
        
    }

    // Move the object 1m/sec downward if object on y axis is greater than -5
    public void DownwardMovement()
    {
        if(this.transform.position.y <= -5)
        {
            return;
        }
        else
        {
            this.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        
    }
}
