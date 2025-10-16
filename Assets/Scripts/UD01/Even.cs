using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Función para mostrar los números pares
        ShowEvenNumbers();
    }

    // Función para mostrar los números pares entre 0 y 100
    void ShowEvenNumbers()
    {
        Debug.Log("Números pares entre 0 y 100:");
        for (int i = 0; i <= 100; i++)
        {
            // Si el número es par, lo mostramos
            if (i % 2 == 0)
            {
                Debug.Log(i);

            }
        }
    }
}
