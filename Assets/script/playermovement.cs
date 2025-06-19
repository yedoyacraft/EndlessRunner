using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float jumpForce = 3f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Gerak maju terus
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        // Jika tekan W dan sedang di tanah
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {
        float rayLength = 0.5f;
        return Physics.Raycast(transform.position, Vector3.down, rayLength);
    }
}
