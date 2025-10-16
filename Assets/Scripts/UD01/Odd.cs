using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Funci�n para mostrar los n�meros impares
        ShowOddNumbers();
    }

    // Funci�n para mostrar los n�meros impares entre 0 y 100
    void ShowOddNumbers()
    {
        Debug.Log("N�meros impares entre 0 y 100:");
        for (int i = 0; i <= 100; i++)
        {
            // Si el n�mero es impar, lo mostramos
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
