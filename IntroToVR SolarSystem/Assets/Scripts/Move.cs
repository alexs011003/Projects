using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10.0f; 
    public float rotSpeed = 80.0f;
    public float boostSpeed = 20.0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        addBoost();
        MoveVehicle();
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

}
