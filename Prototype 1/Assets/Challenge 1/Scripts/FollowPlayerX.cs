using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] Vector3 offset;

    void LateUpdate()
    {
        //offset the camera behind the vehical by adding to the player's position 
        Vector3 desiredposition = plane.transform.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredposition, ref velocity, smoothTime);
        transform.position = smoothedPosition;
    }
}
        