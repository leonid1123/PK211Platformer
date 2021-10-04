using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//для интерфейса пользователя

public class tepMove : MonoBehaviour
{
    public CharacterController2D controller;
    float hMove = 0f;
    float speed = 25f;
    bool jump = false;

    private int BottleCount;//считать бутылки
    public Text ScoreText;//писать текст

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
    public void BottleAdd() //метод для увеличения количества бутылок
    {
        BottleCount += 1;
    }
}
