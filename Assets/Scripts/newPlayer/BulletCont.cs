using UnityEngine;

public class BulletCont : MonoBehaviour
{
    void Start()
    {
        Rigidbody2D bulletRB = gameObject.GetComponent<Rigidbody2D>();
        float a = Mathf.Sign(GameObject.Find("Player").GetComponent<Transform>().rotation.y);
        gameObject.transform.rotation = Quaternion.Euler(0, GameObject.Find("Player").GetComponent<Transform>().rotation.y, 0);
        bulletRB.velocity = new Vector2(5f * a, 0);
        if (a == 1)
        {
            gameObject.transform.Rotate(0, 0, 0);
        }
        else
        {
            gameObject.transform.Rotate(0, -180f, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Ground")
        {
            Destroy(gameObject);
        }
    }
}
