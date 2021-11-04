using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    int visible = 1;
    Vector3 original_vector;
    Vector3 invisible_vector = new Vector3(0, 0, 0);
    GameObject ob;
    void Start()
    {
        original_vector = GameObject.Find("Hand").transform.localScale;
        ob = GameObject.Find("Hand");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            if (ob.transform.localScale == original_vector)
            {
                ob.transform.localScale = invisible_vector;
            }
            else
            {
                ob.transform.localScale = original_vector;
            }
        }
    }
}
