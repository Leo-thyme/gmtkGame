using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("EndGame");

        }
    }


}
