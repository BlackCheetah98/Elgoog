using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class trigger_obj : MonoBehaviour
{
    public int a1, a2, b1, b2;
    public Text text_component;
    public float countdown;
    void Start()
    {
        
    }
    
    void Update()
    {
        if(countdown <= 0f)
        {
            SceneManager.LoadScene(0);
            countdown = 5;
        }
        countdown -= Time.deltaTime;
        text_component.text = Mathf.Round(countdown).ToString();
    }
}
