using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // creating an array of strings to use in my for each loop
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third strings";

        foreach (string item in strings)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
