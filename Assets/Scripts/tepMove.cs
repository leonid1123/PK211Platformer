using UnityEngine;
using UnityEngine.UI;//для интерфейса пользователя


public class tepMove : MonoBehaviour
{
    public CharacterController2D controller;
    float hMove = 0f;
    float speed = 25f;
    bool jump = false;

    private int BottleCount = 0;//считать бутылки
    private int CoinCount = 0;
    public Text BottleText;//писать текст
    public Text CoinText;

    // Update is called once per frame
    void Update()
    {
        BottleText.text = "Bottles:" + BottleCount.ToString();//пишем бутылки каждый кадр
        CoinText.text = "Coins:" + CoinCount.ToString();
        hMove = Input.GetAxisRaw("Horizontal") * speed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        controller.Move(hMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void BottleAdd() //метод для увеличения количества бутылок
    {
        BottleCount += 1;
    }
    public void CoinAdd() //метод для увеличения количества монеток
    {
        CoinCount += 1;
    }

}
