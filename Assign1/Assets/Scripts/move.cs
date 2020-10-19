using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class move : MonoBehaviour
{

    public Transform start;
    public Transform end;
    public float speed;
    public int key;

    void Start()
    {
        key = 0;
    }
    void Update()
    {
        switch (key)
        {
            case 0:
                if (transform.position.x <= -2f) key++;
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(-2, 0, 0), speed * Time.deltaTime);
                break;
            case 1:
                if (transform.position.z <= -3f) key++;
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, -3f), speed * Time.deltaTime);
                break;
            case 2:
                if (transform.position.x >= 1.9f) key++;
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(1.9f, 0, 0), speed * Time.deltaTime);
                break;
            case 3:
                if (transform.position.z >= 2.9f) key=0;
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 3f), speed * Time.deltaTime);
                break;

        }
        
    }
}