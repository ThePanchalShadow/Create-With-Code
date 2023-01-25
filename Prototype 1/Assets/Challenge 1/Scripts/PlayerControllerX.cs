using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    float verticalInput;
    float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //tilt the plane up down based on up down arrow keys
        transform.Rotate(Vector3.right * -rotationSpeed * verticalInput * Time.deltaTime);

        //setting axis to use from input manager
        //horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        ////Moves the vehical forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        ////this Rotates the vehical horizontal input
        //transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontalInput );
    }
}
