using UnityEngine;
using System.Collections;

public abstract class IControllable : ExMono {

    private enum SwipeDirection
    {
        Up,
        Down,
        Right,
        Left
    }

    public virtual void OnInput()
    {
        
    }
    public virtual void OnSwipeUp()
    {
        Debug.Log("SwipeUp");
    }
    public virtual void OnSwipeDown()
    {
        Debug.Log("SwipeDown");
    }
    public virtual void OnSwipeLeft()
    {
        Debug.Log("SwipeLeft");
    }
    public virtual void OnSwipeRight()
    {
        Debug.Log("SwipeRight");
    }
    private void Start()
    {
        
    }

    private SwipeDirection swipe;
    private bool swiping = false;
    private Vector2 lastPosition;
    private bool fingerDown = false;

    private void LateUpdate()
    {
        OnSwipeDown();
#if UNITY_ANDROID
        if (Input.touchCount == 0)
            return;

        if (Input.GetTouch(0).deltaPosition.sqrMagnitude != 0)
        {
            if (swiping == false)
            {
                swiping = true;
                lastPosition = Input.GetTouch(0).position;
                return;
            }
            else
            {

                Vector2 direction = Input.GetTouch(0).position - lastPosition;

                if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                {
                    if (direction.x > 0)
                        OnSwipeRight();
                    else
                        OnSwipeLeft();
                }
                else
                {
                    if (direction.y > 0)
                        OnSwipeUp();
                    else
                        OnSwipeLeft();
                }
            }
        } else {
            swiping = false;
        }
#else
        if(Input.GetAxis("Horizontal") > 0) {
            if(Input.GetAxis("Vertical") > 0) {
                OnSwipeRight();
            } else {
                OnSwipeLeft();
            }
        } else {
            if(Input.GetAxis("Vertical") > 0) {
                OnSwipeUp();
            } else {
                OnSwipeDown();
            }
        }
#endif
    }
}
