using UnityEngine;

public class Sprite_Changer : MonoBehaviour
{
    // Declare our variables here
    public SpriteRenderer theRenderer;
    public Color spriteColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //  Load the SpriteRenderer component from the same object this component is on.
        theRenderer = GetComponent<SpriteRenderer>();

        // Color change instruction goes here
        spriteColor.a = 1.0f;

        // Change the color property of the SpriteRenderer component to green

        if(theRenderer != null)
        {
            theRenderer.color = spriteColor;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
