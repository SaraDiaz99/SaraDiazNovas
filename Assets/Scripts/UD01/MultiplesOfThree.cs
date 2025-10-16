using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Función para mostrar los numeros que son multiplos de tres
        ShowEvenNumbers();

    }

    // Función para mostrar los números multiplos de tres de 0 al 100
    void ShowEvenNumbers()
    {
        Debug.Log("Los números que son multiplos de tres son: ");
        for (int i = 0; i <= 100; i++)
        {
            // Si el número es multiplo de tres, lo mostramos
            if (i % 3 == 0)
            {
                Debug.Log(i);

            }
        }
    }
}
