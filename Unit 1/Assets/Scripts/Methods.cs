using UnityEngine;

public class Methods : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = Add(5, 10, 15);
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Add (int firstNumber, int secondNumber, int thirdNumber)
    {
        return(firstNumber + secondNumber + thirdNumber);
    }
}
