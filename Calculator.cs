using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    // Allows the user to set numbers and Mathematical operation 
    public int number1;
    public int number2;
    public bool plus;
    public bool minus;
    public bool multi;
    public bool div;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plus == true)
        {
            Debug.Log(number1+number2);
        }
        if(minus == true)
        {
            Debug.Log(number1 - number2);
        }
        if(multi == true)
        {
            Debug.Log(number1 * number2);
        }
        if (div == true)
        {
            Debug.Log(number1 / number2);
        }
    }
}
