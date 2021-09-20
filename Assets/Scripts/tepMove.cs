using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tepMove : MonoBehaviour
{
    public CharacterController2D controller;
    float hMove = 0f;
    float speed = 25f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        hMove = Input.GetAxisRaw("Horizontal")*speed;
        if (Input.GetButtonDown("Jump") )
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        controller.Move(hMove*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
