using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftCont : MonoBehaviour
{
    int a = 1;
    void FixedUpdate()
    {
        gameObject.transform.Translate(a*Vector2.up*Time.fixedDeltaTime);
        if (gameObject.transform.position.y>3)
        {
            a = -1;
        }
        if (gameObject.transform.position.y<0)
        {
            a = 1;
        }
    }
}
