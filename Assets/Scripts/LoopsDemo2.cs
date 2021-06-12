using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsDemo2 : MonoBehaviour
{
    public int NumHealthValuesNeeded = 10;
    public List<int> RandomHealthValues;

    float CurrentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Version 1 - use a for loop to generate random values until we have enough stored
        // for(; RandomHealthValues.Count < NumHealthValuesNeeded;)
        // {
        //     RandomHealthValues.Add(Random.Range(80, 120));
        // }

        // Version 2 - using a while loop to fill the list
        while(RandomHealthValues.Count < NumHealthValuesNeeded)
        {
            RandomHealthValues.Add(Random.Range(80, 120));
        }
    }

    // Update is called once per frame
    void Update()
    {
        // below is easy to write but WILL NOT move it slowly. it moves it immediately
        // while(CurrentTime < 5f)
        // {
        //     CurrentTime += Time.deltaTime;
        //     transform.position += new Vector3(0, 0.01f, 0);
        // }
    }
}
