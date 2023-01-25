using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private varibales
    [SerializeField] float speed;
    private float turnSpeed = 40f;
    private float horizontalinput;
    private float verticalinput;
    public Rigidbody rb;
    private float RotateSpeed = 50f;

    private void FixedUpdate()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalinput, 0, verticalinput).normalized;

        rb.AddForce(Vector3.forward * Time.deltaTime * speed * verticalinput, ForceMode.VelocityChange);
        rb.AddForce(Vector3.right * Time.deltaTime * turnSpeed * horizontalinput, ForceMode.VelocityChange);
        transform.Rotate(Vector3.up , Time.deltaTime * RotateSpeed * horizontalinput);
        
        
    }
}
