using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    //public int spriteNum;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        ChangeSprite(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right") || Input.GetKeyDown(KeyCode.D))
        {
            ChangeSprite(1);
            
        }
        else if (Input.GetKeyDown("left") || Input.GetKeyDown(KeyCode.A))
        {
            ChangeSprite(2);
            
        }
        else if (Input.GetKeyUp("right") || Input.GetKeyUp("left") || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            ChangeSprite(0);
            
        } 
    }

    void ChangeSprite(int spriteNum)
    {
        spriteRenderer.sprite = spriteArray[spriteNum];
    }
}
