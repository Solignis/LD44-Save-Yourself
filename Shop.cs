using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{

    public Collider2D PlayerCollider;
    public TextMeshProUGUI text;

    public float Radius = 4f;

    private void Start()
    {
        text.text = null;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        text.text = "press e";

        if (Input.GetKeyDown(KeyCode.E))
        {
            text.text = "opening Shop";
        }
    }

    private void Update()
    {
        
        
    }
   




}
