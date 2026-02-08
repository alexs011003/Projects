using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10.0f; 
    public float rotSpeed = 80.0f;
    public float boostSpeed = 20.0f;


    public float acceleration = 10.0f;
    float currentSpeed = 0;

    public float maxSpeed = 20.0f;

    public float deceleration = 10.0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //addBoost();
        MoveVehicle();
        MoveWithAcceleration();
    }

    void MoveVehicle()
    {
        //Get input to move the spacecraft forward and backward
        float forwardInput = Input.GetAxis("Vertical");
        forwardInput = forwardInput * speed;

        //Get input to turn the spacecraft left and right
        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput = horizontalInput * rotSpeed;
        horizontalInput = horizontalInput * Time.deltaTime;

        //Move and turn the spacecraft
        this.transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        this.transform.Rotate(0, horizontalInput, 0);
    }

    void addBoost()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        speed += boostSpeed;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
        speed -= boostSpeed;
        } 
    }

    void MoveWithAcceleration()
    {
        //Get input to move the spacecraft forward and backward
        float forwardInput = Input.GetAxis("Vertical");
        currentSpeed += acceleration * forwardInput * Time.deltaTime;

        if (currentSpeed > maxSpeed)
        {
        currentSpeed = maxSpeed;
        }

        if (currentSpeed < -maxSpeed)
        {
        currentSpeed = -maxSpeed;
        }   

        if (forwardInput == 0)
        {
            if (currentSpeed > 0)
            {
            currentSpeed -= deceleration * Time.deltaTime;
            }

            if (currentSpeed < 0)
            {
            currentSpeed += deceleration * Time.deltaTime;
            }
        }

        //Get input to turn the spacecraft left and right
        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput = horizontalInput * rotSpeed;
        horizontalInput = horizontalInput * Time.deltaTime;

        //Move and turn the spacecraft
        this.transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
        this.transform.Rotate(0, horizontalInput, 0);
    }

}
