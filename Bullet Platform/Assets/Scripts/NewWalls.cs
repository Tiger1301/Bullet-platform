using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWalls : MonoBehaviour
{
    public GameObject NewWall;
    public Vector3 UpWall = Vector3.up;
    public int CreatedWalls = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&&CreatedWalls<1)
        {
            Instantiate(NewWall, transform.position+UpWall, transform.rotation);
            CreatedWalls++;
        }
    }
}
