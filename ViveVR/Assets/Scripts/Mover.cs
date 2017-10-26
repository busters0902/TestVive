using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]
    float speed;


    [SerializeField]
    bool isInput;
	
	
	// Update is called once per frame
	void Update ()
    {

        if (isInput)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                transform.position += Vector3.forward * speed;
            if (Input.GetKey(KeyCode.DownArrow))
                transform.position += Vector3.back* speed;
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.position += Vector3.left * speed;
            if (Input.GetKey(KeyCode.RightArrow))
                transform.position += Vector3.right * speed;
            if (Input.GetKey(KeyCode.PageUp))
                transform.position += Vector3.up * speed;
            if (Input.GetKey(KeyCode.PageDown))
                transform.position += Vector3.down * speed;
        }
        else
        {
            transform.position += Vector3.forward * speed;
        }

    }
}
