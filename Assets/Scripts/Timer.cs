using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float remainingTime;
    public Animator animator;
    
    public GameObject player;
    

    NewMonoBehaviourScript dzemikBoosterActive;
    bool boosterActive = false;

    public GameObject UIbooster1;
    BoosterScript scriptBooster1;
    float boosterTimer = 0f;

    public void Awake()
    {
        dzemikBoosterActive = player.GetComponent<NewMonoBehaviourScript>();

        scriptBooster1 = UIbooster1.GetComponent<BoosterScript>(); 

    }

    private void Update()
    {
        if (dzemikBoosterActive.BoosterActive == false)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else if (remainingTime < 0)
            {
                remainingTime = 0;

                
            }
        }
        
        
        if (remainingTime <= 0)
        {
            SceneManager.LoadScene("GameOverScene");

        }





        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        countdownText.text = string.Format("{0:00}:{1:00}",minutes, seconds);

        
    }

}
