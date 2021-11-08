using UnityEngine;

public class CoinCont : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Player").GetComponent<tepMove>().CoinAdd();
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
    }
}
