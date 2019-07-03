using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnimation : MonoBehaviour
{
    public Sprite[] sprites;
    int currentSprite = 0;
    float secPerFrame;
    public float framesPerSec;
    float timeUntilChange;
    
    void UpdateSecPerFrame()
    {
        if (framesPerSec == 0)
        {
            framesPerSec = 0.0001f;
        }
        secPerFrame = 1f / framesPerSec;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateSecPerFrame();
        timeUntilChange = secPerFrame;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSecPerFrame();
        GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
        timeUntilChange -= Time.deltaTime;
        if (framesPerSec > 0 && timeUntilChange < 0)
        {
            timeUntilChange = secPerFrame;
            currentSprite++;
            if (currentSprite >= sprites.Length)
            {
                currentSprite = 0;
            }
        }
        else if (framesPerSec < 0 && timeUntilChange < 0)
        {
            timeUntilChange = -secPerFrame;
            currentSprite--;
            if (currentSprite < 0)
            {
                currentSprite = sprites.Length - 1;
            }
        }
    }
}
