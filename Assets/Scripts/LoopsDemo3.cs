using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsDemo3 : MonoBehaviour
{
    public List<string> FirstNames;
    public List<string> LastNames;

    List<string> ChosenNames = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        // pick a first and last name and store in chosen names
        // do not pick the same first or last name multiple times

        // work out smallest number of names to pick with being unique
        int numToPick = Mathf.Min(FirstNames.Count, LastNames.Count);

        // validity check the lists of names
        if (numToPick == 0)
            Debug.LogError("FirstNames or LastNames is empty. Must have at least one in each.");

        // pick the names
        while (ChosenNames.Count < numToPick)
        {
            // pick a random first and last name
            string firstName = FirstNames[Random.Range(0, FirstNames.Count)];
            string lastName = LastNames[Random.Range(0, LastNames.Count)];

            // remove the names so they can't be picked again
            FirstNames.Remove(firstName);
            LastNames.Remove(lastName);

            // store the new name in chosen names
            ChosenNames.Add(firstName + " " + lastName);
        }

        // display all the names
        foreach(var chosenName in ChosenNames)
        {
            Debug.Log(chosenName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
