using UnityEditor;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed);
    }
}
