using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTwean : MonoBehaviour
{
    public LeanTweenType ease;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveX(gameObject,0.5f,4.5f).setLoopPingPong().setEase(ease);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
