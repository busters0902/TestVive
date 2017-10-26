using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeeder : MonoBehaviour
{

    [SerializeField]
    Rigidbody rig;

    public float speed;

    private void Update()
    {
        //float mag = rig.velocity.magnitude;
        //if (mag < 5.0f)
        //{
        //    Destroy(gameObject, 1.0f);
        //}
    }

}
