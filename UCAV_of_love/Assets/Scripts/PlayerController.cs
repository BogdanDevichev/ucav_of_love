using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float xBound;
    public float positiveZBound;
    public float negativeZBound;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.right * speed * horizontalInput * Time.deltaTime, ForceMode.Impulse);
        playerRb.AddForce(Vector3.forward * speed * verticalInput * Time.deltaTime, ForceMode.Impulse);
        if (transform.position.x > xBound)
            transform.position = new Vector3(xBound,
                                             transform.position.y,
                                             transform.position.z);
        if (transform.position.x < -xBound)
            transform.position = new Vector3(-xBound,
                                             transform.position.y,
                                             transform.position.z);
        if (transform.position.z > positiveZBound)
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y,
                                             positiveZBound);
        if (transform.position.z < negativeZBound)
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y,
                                             negativeZBound);
    }
}
