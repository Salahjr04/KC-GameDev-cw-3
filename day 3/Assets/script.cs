using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    //heroThings
    string heroName = "musashi";
    int heroPower = 15;
    int playerspeed = 4;

    //villainThings
    string villainName = "azoz";
    int villainPower = 12;



    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villainPower)
        {
            print(heroName + "is stronger");
        }
        else if (villainPower == heroPower)
        {

            print("No one is stronger than the other");

        }
        else
        {
            print(villainName + "is stronger");
        }
    }
    void SetSpeed()
    {
        float speed = 5.5f;
        speed = playerspeed;
        print("The last speed was " + playerspeed);
        print("the new speed is " + speed);


    }
}