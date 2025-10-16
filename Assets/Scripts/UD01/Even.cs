using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Funci�n para mostrar los n�meros pares
        ShowEvenNumbers();
    }

    // Funci�n para mostrar los n�meros pares entre 0 y 100
    void ShowEvenNumbers()
    {
        Debug.Log("N�meros pares entre 0 y 100:");
        for (int i = 0; i <= 100; i++)
        {
            // Si el n�mero es par, lo mostramos
            if (i % 2 == 0)
            {
                Debug.Log(i);

            }
        }
    }
}
