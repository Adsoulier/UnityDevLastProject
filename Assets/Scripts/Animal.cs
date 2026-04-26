using UnityEngine;

public class Animal : MonoBehaviour
{
    
    private Rigidbody rigidBody;

    private bool isOnGround = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics.gravity *= 10;
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
       transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * 40.0f * Time.deltaTime);
       rigidBody.linearVelocity = transform.forward * Input.GetAxis("Vertical") * 5.0f ;  
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            Jump(300.0f);
        }
    }

    private void Jump(float jumpForce)
    {
        rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
