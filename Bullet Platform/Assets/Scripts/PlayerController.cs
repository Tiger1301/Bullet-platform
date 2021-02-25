using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5;
    public float JumpSpeed = 5;
    public float VerticalSpeed = 0;
    public float Gravity = 9.81f;
    CharacterController cController;
    // Start is called before the first frame update
    void Start()
    {
        cController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float Lateral = Input.GetAxis("Horizontal");
        Vector3 LateralSpeed = this.transform.right * Lateral * Speed;

        if (!cController.isGrounded)
        {
            VerticalSpeed = VerticalSpeed - Gravity * Time.deltaTime;
        }
        else
        {
            VerticalSpeed = -Gravity;
        }
        if (Input.GetKeyDown(KeyCode.Space) && cController.isGrounded)
        {
            VerticalSpeed = JumpSpeed;
        }
        cController.Move((LateralSpeed + Vector3.up * VerticalSpeed) * Time.deltaTime);
    }
}
