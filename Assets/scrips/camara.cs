using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform bird;
    public Camera mainCamera;

    void Update()
    {
        Vector3 birdPosition = mainCamera.WorldToViewportPoint(bird.position);

        if (birdPosition.x < 0 || birdPosition.y < 0 || birdPosition.y > 1)
        {
            // Trigger game over logic
            Debug.Log("Game Over");
        }
    }
}
