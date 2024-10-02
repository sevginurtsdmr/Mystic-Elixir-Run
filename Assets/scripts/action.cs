using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    private int konumdurumu = 2;
    public float moveSpeed = 5f; 
    private Vector2 startTouchPosition, endTouchPosition;
    private float minSwipeDistance = 50f;
   

    private void Update()
    {
        Debug.Log(konumdurumu);
        
        HandleTouchInput();

        // Klavye Girişlerini İşleme
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            konumdurumu++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            konumdurumu--;
        }

        
        // if(Input.GetKeyDown(KeyCode.RightArrow))
        // {
        //  //Debug.Log("sagabasıldı");
        //  konumdurumu++;
        // }
        // if(Input.GetKeyDown(KeyCode.LeftArrow))
        // {
        //     //Debug.Log("solabasıldı");
        //     konumdurumu--;
        // }

        if (konumdurumu > 3)
        {
            konumdurumu = 3;
        }
        else if (konumdurumu < 1)
        {
            konumdurumu = 1;
        }

        // if (konumdurumu == 1)
        // {
        //     cube.gameObject.transform.position = new Vector3(-2, 0, 0);
        //     
        //     Vector3 CharNewPos = Vector3.Lerp(transform.position, new Vector3(-2, 0, -6),0.01f);
        //     transform.position = CharNewPos;
        // }
        // else if (konumdurumu == 2)
        // {
        //     cube.gameObject.transform.position = new Vector3(0, 0, 0);
        //     
        //     Vector3 CharNewPos = Vector3.Lerp(transform.position, new Vector3(0, 0, -6),0.01f);
        //     transform.position = CharNewPos;
        //     
        // }
        // else
        // {
        //     cube.gameObject.transform.position = new Vector3(2, 0, 0);
        //    
        //     Vector3 CharNewPos = Vector3.Lerp(transform.position, new Vector3(2, 0, -6),0.01f);
        //     transform.position = CharNewPos;
        // }
        Vector3 targetPosition = transform.position;
        if (konumdurumu == 1)
        {
            targetPosition = new Vector3(-2, 0, -6);
        }
        else if (konumdurumu == 2)
        {
            targetPosition = new Vector3(0, 0, -6);
        }
        else
        {
            targetPosition = new Vector3(2, 0, -6);
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        
    }
    void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position;
                DetectSwipe();
            }
        }
    }

    void DetectSwipe()
    {
        float distance = (endTouchPosition - startTouchPosition).magnitude;
        if (distance >= minSwipeDistance)
        {
            Vector2 direction = endTouchPosition - startTouchPosition;
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                // Yatay Swipe
                if (direction.x > 0)
                {
                    konumdurumu++; // Sağa kaydırma
                }
                else
                {
                    konumdurumu--; // Sola kaydırma
                }
            }
            else
            {
                // Dikey Swipe
                if (direction.y > 0)
                {
                    // Yukarı kaydırma (zıplama ekleyebilirsiniz)
                }
                else
                {
                    // Aşağı kaydırma (gerekirse)
                }
            }
        }
    }
}
