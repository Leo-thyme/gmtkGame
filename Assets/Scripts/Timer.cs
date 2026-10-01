using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float remainingTime;
    public Animator animator;
    

    public PlayerMoveset dzemikBoosterActive;
    
    public BoosterScript scriptBooster1;
    // inspector value (iv)

    

    private void Update()
    {
        if (dzemikBoosterActive.BoosterActive) return;
        
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else
        {
            remainingTime = 0;
            SceneManager.LoadScene("GameOverScene");

        }





        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        countdownText.text = string.Format("{0:00}:{1:00}",minutes, seconds);

        
    }

}
