using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }

    public void FinishedLevel()
    {
        SceneManager.LoadScene(1);
    }

    
    
}
