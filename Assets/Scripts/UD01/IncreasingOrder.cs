using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    // Zona de vaariables globales
    public int num1;
    public int num2;
    public int num3;


    void Start()
    {

        if (num1 <= num2 && num2 <= num3)
        {

            Debug.Log("Este es el orden creciente ");

        }
        else 
        {

            Debug.Log("Este no está en orden creciente ");

        }

    }
   
}
