using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    private float speed = 15f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
