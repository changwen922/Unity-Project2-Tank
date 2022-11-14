using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canaoncontroller : MonoBehaviour
{
    public float turnSpeed=20;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        ClampRot(-30,30);
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime,0);
        }

    }


    Vector3 v3;
    /// <summary>
    /// 限制倾斜角度
    /// </summary>
    void ClampRot(float minZ,float maxZ)
    {
        v3 = transform.localEulerAngles;

        if (transform.localEulerAngles.y > maxZ && transform.localEulerAngles.y <= maxZ+10)//z控制在30一下
        {
            v3.y = maxZ;
        }
        else if (transform.localEulerAngles.y > 350+ minZ && transform.localEulerAngles.y < 360+ minZ)
        {
            v3.y = 360 + minZ;
        }
        transform.localEulerAngles = v3;
    }


}
