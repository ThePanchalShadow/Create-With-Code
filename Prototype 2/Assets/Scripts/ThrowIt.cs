using UnityEngine;

public class ThrowIt : MonoBehaviour
{
    public float speed = 40f;
    // Update is called once per frame
    void Update()
    {
        if (tag == "Bottle")
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
