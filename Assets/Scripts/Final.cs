using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    int nextSceneIndex = 0;

    public void Awake()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(nextSceneIndex);

        }
    }


}
