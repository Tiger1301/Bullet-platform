using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;
    public float Distance = 10;
    public float Height = 2;
    public float UpSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 StartPosition = Target.position + new Vector3(0, Height, -Distance);
    }

    // Update is called once per frame
    void Update()
    {
        if(Target.transform.position.y>transform.position.y)
        {
            transform.Translate(Vector3.up * UpSpeed * Time.deltaTime);
        }
    }
}
