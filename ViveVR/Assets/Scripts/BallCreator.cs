
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    [SerializeField]
    Vector3 pos;

    [SerializeField]
    Vector3 size;

    [SerializeField]
    float ballPower;

    [SerializeField]
    GameObject ballPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            CreateBall();
        }
    }

    GameObject CreateBall()
    {
        var obj = Instantiate<GameObject>(ballPrefab);
        obj.transform.position = CreateBallPostion();
        var rig = obj.GetComponent<Rigidbody>();
        rig.velocity = CreateRandomRotation() * Vector3.forward * ballPower;
        //obj.transform.rotation = CreateRandomRotation();
        return obj;
    }

    Vector3 CreateBallPostion()
    {
        float x = Random.Range(0, size.x);
        float y = Random.Range(0, size.y);
        float z = Random.Range(0, size.z);

        var pos_ = new Vector3(pos.x + x, pos.y + y, pos.z + z);
        return pos_;
    }

    Quaternion CreateRandomRotation()
    {
        //return Quaternion.FromToRotation(Vector3.zero, new Vector3())
        return Quaternion.Euler(
            Random.Range(0f,360f), 
            Random.Range(0f, 360f), 
            Random.Range(0f, 360f));
    }

}
