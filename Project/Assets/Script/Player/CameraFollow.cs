using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    // Define boundaries for the ground or play area
    public float minX, maxX, minY, maxY;

    void Start()
    {
        // You can initialize or set boundaries here if needed
    }

    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        // Clamp camera position within boundaries
        float clampedX = Mathf.Clamp(smoothPosition.x, minX, maxX);
        float clampedY = Mathf.Clamp(smoothPosition.y, minY, maxY);

        transform.position = new Vector3(clampedX, clampedY, smoothPosition.z);
    }
}