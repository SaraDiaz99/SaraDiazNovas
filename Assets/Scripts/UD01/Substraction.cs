using UnityEngine;

public class Substraction : MonoBehaviour
{
    // Variables globales
    public int inputNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Funci�n para mostrar la resta
        ShowRest(inputNumber);
    }

    // Funci�n para calcular y mostrar la resta de los n�meros del 1 al n�mero introducido
    void ShowRest(int number)
    {
        int rest = 0;  // Variable para almacenar la resta

        // Ciclo para restar los n�meros desde 1 hasta el n�mero introducido
        for (int i = 1; i <= number; i++)
        {
            rest -= i;  // Agregamos el valor actual de i a la resta
        }

        // Mostramos la resta en la consola
        Debug.Log("La resta de los n�meros del 1 al " + number + " es: " + rest);
    }
}
