using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 10.0f; 
    float rotSpeed = 80.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        forwardInput = forwardInput * speed;

        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput = horizontalInput * rotSpeed;
        horizontalInput = horizontalInput * Time.deltaTime;

        this.transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        this.transform.Rotate(0, horizontalInput, 0);

    }
}
