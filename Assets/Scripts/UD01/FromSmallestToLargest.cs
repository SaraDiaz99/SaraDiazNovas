using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    // Zona de variables globales
    public int num1;
    public int num2;
    public int num3;

    void Start()
    {
        // Funci�n que ordena y muestra los n�meros
        ShowNumbersInOrder();
    }

    void ShowNumbersInOrder()
    {
        int smallest, middle, largest;

        // Compara los n�meros para encontrar el orden correcto
        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
            if (num2 <= num3)
            {
                middle = num2;
                largest = num3;
            }
            else
            {
                middle = num3;
                largest = num2;
            }
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
            if (num1 <= num3)
            {
                middle = num1;
                largest = num3;
            }
            else
            {
                middle = num3;
                largest = num1;
            }
        }
        else
        {
            smallest = num3;
            if (num1 <= num2)
            {
                middle = num1;
                largest = num2;
            }
            else
            {
                middle = num2;
                largest = num1;
            }
        }

        // Muestra los n�meros en el orden correcto en la consola
        Debug.Log("Los n�meros de menor a mayor son:");
        Debug.Log(smallest);
        Debug.Log(middle);
        Debug.Log(largest);
    }
}
