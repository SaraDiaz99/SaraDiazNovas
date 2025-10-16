using UnityEngine;

public class Change : MonoBehaviour
{

    public int[] intArray = new int[5] { 1, 1, 1, 1, 1 };



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        intArray[0] = 42;
        intArray[4] = 42;
        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
        Debug.Log(intArray[2]);
        Debug.Log(intArray[3]);
        Debug.Log(intArray[4]);



    }

   
}
