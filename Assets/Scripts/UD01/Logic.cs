using UnityEngine;

public class Logic : MonoBehaviour
{
    
    public bool[] boolArray = new bool[3] { false, false, false };

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        boolArray[0] = true;
        Debug.Log(boolArray[0]);
        Debug.Log(boolArray[1]);
        Debug.Log(boolArray[2]);
    }

    
}
