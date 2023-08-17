using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public Sprite[] sprites; // array of sprites to use for the image
    private int currentIndex = 0; // index of the current sprite to use

    void Start()
    {
        // get the image component attached to this game object
        Image image = GetComponent<Image>();

        // set the image's sprite to the first sprite in the array
        image.sprite = sprites[currentIndex];

        // increment the currentIndex to point to the next sprite in the array
        currentIndex++;
    }

    public void ChangeSprite()
    {
        // get the image component attached to this game object
        Image image = GetComponent<Image>();

        // check if the currentIndex is within the bounds of the array
        if (currentIndex < sprites.Length)
        {
            // set the image's sprite to the current sprite in the array
            image.sprite = sprites[currentIndex];
            // increment the currentIndex to point to the next sprite in the array
            currentIndex++;
        }
        else
        {
            // if we've reached the end of the array, reset the currentIndex to 0
            currentIndex = 0;
            // set the image's sprite to the first sprite in the array
            image.sprite = sprites[currentIndex];
            // increment the currentIndex to point to the next sprite in the array
            currentIndex++;
        }
    }

}
