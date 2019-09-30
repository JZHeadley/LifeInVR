using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireAnimation : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animateImageObj;
    public float framesPerSecond = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animateImageObj.sprite = animatedImages[(int) (Time.time*10) % animatedImages.Length];
        // int index = (int)(Time.time * framesPerSecond);
        // index = index % frames.Length;
        // GetComponent<Renderer>().material.mainTexture = frames[index];
         
    }
}
