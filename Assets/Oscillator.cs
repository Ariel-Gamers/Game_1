using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{

    Vector3 startingPosition;

    [SerializeField]
    float speed = 5f;

    [SerializeField]
    float limit = 3f;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        //print(Time.deltaTime);

        // left border
        if(currentPosition.x < startingPosition.x - limit)
        {
            speed = -speed;
        }
        // right border
        else if (currentPosition.x > startingPosition.x + limit)
        {
            speed = -speed;
        }

        transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
    }
}
