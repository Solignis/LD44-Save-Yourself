using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.GetComponent<HealthBar>().health = Player.GetComponent<HealthBar>().health - 1;
        if (Player.GetComponent<HealthBar>().health <= 0)
        {

            SceneManager.LoadScene("Level1");
        }

    }
}
