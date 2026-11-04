using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class IFSF : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemerature = 70.0f;
    float coldLimitTemperature = 40.0f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;

    }

    void TemperatureTest()
    {
        // If the coffie's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemerature)
        {
            // ... do this .
            print("Coffee is too cold.");
        }
        // if it isnt't, but the coffee temperature is less than the coldest drinking temperature.
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }


    }
}
