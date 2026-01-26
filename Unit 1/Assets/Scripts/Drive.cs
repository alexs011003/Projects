using UnityEngine;

public class Drive : MonoBehaviour
{
    public float forwardSpeed = 10.0f;
    public float nitroBoost = 10.0f;
    public float rotateSpeed = 80.0f;
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
        NitroBoost();
        CarMove();

    }

    void CarMove()
    {
        //Car move forward and backward
        float forwardInput = Input.GetAxis("Vertical");
        forwardInput = forwardInput * forwardSpeed;
        this.transform.Translate(Vector3.forward * Time.deltaTime  * forwardInput);

        //Car rotate left and right
        float rotateInput = Input.GetAxis("Horizontal");
        rotateInput *= rotateSpeed;
        rotateInput *= Time.deltaTime;
        this.transform.Rotate(0, rotateInput, 0);
    }

    void NitroBoost()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            forwardSpeed += nitroBoost;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            forwardSpeed -= nitroBoost;
        }
    }
}
