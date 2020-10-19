using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSphere : MonoBehaviour
{
    public float friction;
    public float mass;
    public float radius;

    [NonSerialized]
    public Vector3 currentV;

    // Start is called before the first frame update
    void Start()
    {
        currentV = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

       
        //摩擦力
        Vector3 frictionDeltaV = -Time.deltaTime * friction * currentV.normalized;
        //防止摩擦力反向运动
        Vector3 finalV = currentV + frictionDeltaV;
        if (finalV.x * currentV.x <= 0)
            frictionDeltaV.x = -currentV.x;
        if (finalV.y * currentV.y <= 0)
            frictionDeltaV.y = -currentV.y;
        if (finalV.z * currentV.z <= 0)
            frictionDeltaV.z = -currentV.z;

        Vector3 prePos = transform.position;

        //应用加速度
        Vector3 curV = currentV + frictionDeltaV;
        transform.Translate((curV + currentV) * Time.deltaTime / 2);
        currentV = curV;
        //动完取一个新位置
        
        Vector3 pos = transform.position;

        if (pos.x <= -18.5 || pos.x >= 18.5)
        {
            Vector3 v1 = new Vector3(-currentV.x, 0, currentV.z);
            //如果有碰撞，位置回退，防止穿透
            transform.position = prePos;
            currentV = v1;
        }
        if (pos.z <= -8.5 || pos.z >= 8.5)
        {
            Vector3 v1 = new Vector3(currentV.x, 0, -currentV.z);
            //如果有碰撞，位置回退，防止穿透
            transform.position = prePos;
            currentV = v1;
        }

    }
}
