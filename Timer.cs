using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float TimeLeft;
    public GameObject Player;
    public TextMeshProUGUI text;
   
    bool timerIsActive = true;
    // Update is called once per frame
    private void Start()
    {
        TimeLeft = Player.GetComponent<HealthBar>().numOfHearts * 5;
        InvokeRepeating("HealthDamage", 5f, 5f);

    }
    void Update()
    {
      
        if (timerIsActive)
        {
            TimeLeft -= Time.deltaTime;
            text.text = TimeLeft.ToString("f0");
            if(TimeLeft <= 0)
            {
                TimeLeft = 0;

                timerIsActive = false;
            }

        }
        if (Player.GetComponent<HealthBar>().health == 0)
        {
            SceneManager.LoadScene("Level1");
        }

        

    }
    void HealthDamage()
    {
        
        Player.GetComponent<HealthBar>().health = Player.GetComponent<HealthBar>().health - 1;

    }
    
    
}
