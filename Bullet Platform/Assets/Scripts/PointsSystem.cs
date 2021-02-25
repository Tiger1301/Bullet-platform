using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsSystem : MonoBehaviour
{
    public float MaxHeight = 0;
    public Text Score;
    PlayerController PC;
    // Start is called before the first frame update
    void Start()
    {
        PC = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>MaxHeight)
        {
            MaxHeight = transform.position.y;
        }
        if(PC.transform.position.y>transform.position.y)
        {
            transform.position = PC.transform.position;
        }
        Score.text = MaxHeight.ToString();
    }
}
