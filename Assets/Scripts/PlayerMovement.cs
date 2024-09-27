using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // public float moveSpeed;
    public float speed = 10f;  
    public float maxX = 3f;    
    public float minX = -3f;   

    private Vector3 touchStart; 
    private Vector3 playerStart; 

    private void Update()
    {
        // MovePlayer();
        HandleTouchInput();
    }
    // void MovePlayer(){
    //     float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    //     float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    //     transform.Translate(xValue,0,zValue);
    // }

    void HandleTouchInput()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchStart = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
                playerStart = transform.position;
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                Vector3 currentTouch = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
                float deltaX = currentTouch.x - touchStart.x;

                Vector3 newPosition = playerStart + new Vector3(deltaX, 0, 0);
                newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

                transform.position = newPosition;
            }
        }
    }
}
