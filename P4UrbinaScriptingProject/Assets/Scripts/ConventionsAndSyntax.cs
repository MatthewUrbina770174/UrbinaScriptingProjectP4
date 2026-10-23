using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is here to tell me the x position of my object in the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //this if statement is going to check the hight of my game object
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
        else
        {
            Debug.Log("I am still in the air");
        }
    }

}
