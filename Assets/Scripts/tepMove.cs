using UnityEngine;
using UnityEngine.UI;//��� ���������� ������������


public class tepMove : MonoBehaviour
{
    public CharacterController2D controller;
    float hMove = 0f;
    float speed = 25f;
    bool jump = false;

    private int BottleCount = 0;//������� �������
    private int CoinCount = 0;
    public Text BottleText;//������ �����
    public Text CoinText;

    // Update is called once per frame
    void Update()
    {
        BottleText.text = "Bottles:" + BottleCount.ToString();//����� ������� ������ ����
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
    public void BottleAdd() //����� ��� ���������� ���������� �������
    {
        BottleCount += 1;
    }
    public void CoinAdd() //����� ��� ���������� ���������� �������
    {
        CoinCount += 1;
    }

}
