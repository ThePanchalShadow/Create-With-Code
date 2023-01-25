using UnityEngine;

public class DestoryLater : MonoBehaviour
{
    private float topBound = 40;
    private float lowerBound = -10;
    static int Count = 0;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Count += 1;
            Debug.Log("You Missed "+Count+" Animals");
            Destroy(gameObject);
        }

    }
}
