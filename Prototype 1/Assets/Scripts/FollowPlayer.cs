
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        //offset the camera behind the vehical by adding to the player's position 
        Vector3 desiredposition = player.transform.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredposition,ref velocity,  smoothTime);
        transform.position = smoothedPosition;
    }
}
        