using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Función para mostrar los numeros que son multiplos de tres y de dos
        ShowEvenNumbers();

    }

    // Función para mostrar los números multiplos de tres y de dos de 0 al 100
    void ShowEvenNumbers()
    {
        Debug.Log("Los números que son multiplos de tres y de dos son: ");
        for (int i = 0; i <= 100; i++)
        {
            // Si el número es multiplo de tres y de dos, lo mostramos
            if (i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log(i);

            }
        }
    }
}
