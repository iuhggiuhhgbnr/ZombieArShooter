using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roatate : MonoBehaviour
{
    public Transform follow_object;
    public float follow_speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(follow_object);
        transform.position = Vector3.Lerp(transform.position, follow_object.position, follow_speed * Time.deltaTime);
    }
}
