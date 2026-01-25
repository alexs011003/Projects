using UnityEngine;

public class Drive : MonoBehaviour
{
    float forwardSpeed = 10.0f;
    float rotateSpeed = 80.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        //if (Input.GetKey(KeyCode.W))
        //{
        //  this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //  this.transform.Translate(Vector3.forward * Time.deltaTime * speed * -1);
        //}

        float forwardInput = Input.GetAxis("Vertical");
        forwardInput = forwardInput * forwardSpeed;

        this.transform.Translate(Vector3.forward * Time.deltaTime  * forwardInput);

        float rotateInput = Input.GetAxis("Horizontal");
        rotateInput *= rotateSpeed;
        rotateInput *= Time.deltaTime;
        this.transform.Rotate(0, rotateInput, 0);

    }
}
