using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject imageobj;
    public GameObject canvas;
    public Sprite[] images;

    private int count; 
    private void Start()
    {
        count = 0;        
    }
    public void nextPressed() 
    {
        if (count == 0) 
        {
            Image image = imageobj.GetComponent<Image>();
            image.sprite = images[0];
        }
        if (count == 1)
        {
            Image image = imageobj.GetComponent<Image>();
            image.sprite = images[1];
        }
        if (count == 2)
        {
            canvas.SetActive(false);    
        }
        count++;        
    }
}
