using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//��� ���������� ������������

public class tepMove : MonoBehaviour
{
    public CharacterController2D controller;
    float hMove = 0f;
    float speed = 25f;
    bool jump = false;

    private int BottleCount;//������� �������
    public Text ScoreText;//������ �����

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + BottleCount.ToString();
        hMove = Input.GetAxisRaw("Horizontal")*speed;
        Debug.Log(hMove);
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
    public void BottleAdd() //����� ��� ���������� ���������� �������
    {
        BottleCount += 1;
    }
}
