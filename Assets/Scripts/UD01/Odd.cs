using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Función para mostrar los números impares
        ShowOddNumbers();
    }

    // Función para mostrar los números impares entre 0 y 100
    void ShowOddNumbers()
    {
        Debug.Log("Números impares entre 0 y 100:");
        for (int i = 0; i <= 100; i++)
        {
            // Si el número es impar, lo mostramos
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
