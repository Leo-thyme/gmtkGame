using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{

    public float lenght = 0f;
    

   
    void Update()
    {
        lenght += Time.deltaTime;
        if (lenght >= 26f)
        {
            SceneManager.LoadScene("main menu");
        }
    }
}
