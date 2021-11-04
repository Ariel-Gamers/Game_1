using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    // Start is called before the first frame update
    float upper_limit = 5;
    float min_limit = 1;
    float beat = 3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x > upper_limit)
        {
            beat = -1f;
        }
        else if ( transform.localScale.x < min_limit)
        {
            beat = 1f;
        }

        transform.localScale += new Vector3(beat*Time.deltaTime, beat*Time.deltaTime, Time.deltaTime*beat);

    }
}
