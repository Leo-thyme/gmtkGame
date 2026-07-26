using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{

    public float lenght = 0f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lenght += Time.deltaTime;
        if (lenght >= 26f)
        {
            SceneManager.LoadScene("main menu");
        }
    }
}
