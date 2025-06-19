using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float minBlow = 0;
    public float maxBlow;
    public float maxHeight;
    public MichrophoneInputLoudness michrophone;
    public float turnSpeed = 10f;
    private Rigidbody rb;
    public GameObject vfx;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Blow(Mathf.Clamp(michrophone.loudness, minBlow, maxBlow));
        turn();
    }

    public void Blow(float y)
    {
        if (transform.position.y < maxHeight)
        {
            transform.Translate(new Vector3(0, y, 0) * Time.deltaTime);
            //transform.localScale = new Vector3(y, y ,y);
        }
    }

    public void turn()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0, 0) * Time.deltaTime * turnSpeed;

        //Vector3 movement = new Vector3(x, 0, 0).normalized * turnSpeed * Time.fixedDeltaTime;
        //rb.MovePosition(rb.position + movement);
    }
}
