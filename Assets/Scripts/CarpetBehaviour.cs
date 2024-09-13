using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpetBehaviour : MonoBehaviour
{
    private BoxCollider2D carpetCollider;

    private void Awake()
    {
        carpetCollider = GetComponent<BoxCollider2D>();
    }

    public bool IsPointOverCarpet(Vector2 point)
    {
        return carpetCollider.OverlapPoint(point);
    }
}
