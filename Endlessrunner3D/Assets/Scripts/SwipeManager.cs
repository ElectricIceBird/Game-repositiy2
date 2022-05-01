using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour
{
     PlayerController player;
    public static bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    private bool isDragging = false;
    private Vector2 startTouch, swipeDelta;
  
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void Update()
    {
        tap = swipeDown = swipeLeft = swipeUp = swipeRight = false;
        #region Standalon Inputs
        if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            isDragging = true;
            startTouch = Input.mousePosition;
        }else if (Input.GetMouseButtonUp(0))
        {
            
            isDragging = false;
            Reset();
        }
        #endregion
        swipeDelta = Vector2.zero;
        if(isDragging)
        {
            if(Input.touches.Length < 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }
        }
        if(swipeDelta.magnitude > 125)
        {
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if(Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                {
                   StartCoroutine(player.GoLeft());
                   
                    swipeLeft = true;
                }
                else
                {
                   StartCoroutine(player.GoRight());
                    swipeRight = true;
                    

                }
            }
            else
            {
                if(y < 0)
                {
                    swipeDown = true;
                }
                else
                {
                    swipeUp = true;
                }
            }
            Reset();
        }
    }
    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDragging = false;
    }

}
