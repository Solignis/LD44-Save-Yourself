using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{

    public GameObject completeLevelUI;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Level complete");
        completeLevelUI.SetActive(true);
        
    }
}
