using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Funci�n para mostrar los numeros que son multiplos de tres
        ShowEvenNumbers();

    }

    // Funci�n para mostrar los n�meros multiplos de tres de 0 al 100
    void ShowEvenNumbers()
    {
        Debug.Log("Los n�meros que son multiplos de tres son: ");
        for (int i = 0; i <= 100; i++)
        {
            // Si el n�mero es multiplo de tres, lo mostramos
            if (i % 3 == 0)
            {
                Debug.Log(i);

            }
        }
    }
}
