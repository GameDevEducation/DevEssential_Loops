using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsDemo1 : MonoBehaviour
{
    public List<string> FirstNames;

    // Start is called before the first frame update
    void Start()
    {
        // perform an action (in this Debug.Log) with all names in FirstNames
        foreach(var firstName in FirstNames)
        {
            Debug.Log("First Name: " + firstName);
        }

        // perform an action with both the value and position of that value in FirstNames
        // ++index is the same as index = index + 1
        // ++index is the same as index++ WHEN it is used at the end of the for () block
        // int index = 0 runs once to setup the loop
        // index < FirstNames.Count runs every time to check if the loop block can run
        // ++index runs at the end of every loop block
        for(int index = 0; index < FirstNames.Count; ++index)
        {
            Debug.Log("Name " + (index + 1) + " is " + FirstNames[index]);
        }

        // loop all first names
        // if the name is SKIP then display nothing
        // if the name is EXIT then stop displaying names
        for(int index = 0; index < FirstNames.Count; ++index)
        {
            if (FirstNames[index] == "SKIP")
                continue; // continue jumps to the end of the loop block skipping over any code in between

            if (FirstNames[index] == "EXIT")
                break; // immediately exits the loop

            Debug.Log("Name " + (index + 1) + " is " + FirstNames[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
