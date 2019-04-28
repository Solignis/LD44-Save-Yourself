using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FallFromScreen : MonoBehaviour
{
    // Start is called before the first frame update
    float treshold = -10f;

    private void Update()
    {
        if(transform.position.y <= treshold)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
