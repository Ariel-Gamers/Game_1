using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardClickMover : MonoBehaviour
{
    [SerializeField] float stepSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, stepSize, 0);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -stepSize, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(stepSize, 0, 0);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-stepSize, 0, 0);

        }
    }
}
