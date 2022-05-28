using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : MonoBehaviour
{
    public LeanTweenType ease;
    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject,scale,0.5f).setEase(ease);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
