using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

// 입력 관리자
public class InputManager : MonoBehaviour
{
    public GameManager gameManager;
    public CarpetBehaviour carpet;
    public float shakeTreshold = 2f;

    private Vector3 acceleration;
    private Vector3 lastAcceleration;

    private void Update()
    {
        HandleTouchInput();
        HandleShakeInput();
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (carpet.IsPointOverCarpet(touchPosition))
            {
                gameManager.TryCollectItem();
            }
        }

        // For testing in Unity Editor
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (carpet.IsPointOverCarpet(mousePosition))
            {
                gameManager.TryCollectItem();
            }
        }
    }

    private void HandleShakeInput()
    {
        acceleration = Input.acceleration;
        float deltaAcceleration = (acceleration - lastAcceleration).magnitude;
        if (deltaAcceleration > shakeTreshold)
        {
            gameManager.TryCollectItem();
        }
        lastAcceleration = acceleration;
    }
}
