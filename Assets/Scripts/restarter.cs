using UnityEngine;
using UnityEngine.SceneManagement;

public class restarter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("lvl1");
    }
}
