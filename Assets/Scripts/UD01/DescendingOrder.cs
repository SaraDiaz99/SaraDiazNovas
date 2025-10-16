using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Zona de variables globales
    public int num1;
    public int num2;
    public int num3;


    void Start()
    {

        if (num3 <= num2 && num2 <= num1)
        {

            Debug.Log("Este es el orden descentente ");

        }
        else
        {

            Debug.Log("Este no está en orden descendente ");

        }

    }
}
