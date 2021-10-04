using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottleCont : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Player").GetComponent<tepMove>().BottleAdd();
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
    }
}
