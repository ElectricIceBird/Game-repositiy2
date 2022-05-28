using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongTwean : MonoBehaviour
{
    public LeanTweenType ease;
    public Vector3 scale;
    public float tweenMove,tweenspeed;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject,scale,.5f);
        
        LeanTween.moveY(gameObject,tweenMove,tweenspeed).setLoopPingPong().setEase(ease).setDelay(.5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
