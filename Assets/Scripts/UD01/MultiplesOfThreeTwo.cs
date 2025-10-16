using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Funci�n para mostrar los numeros que son multiplos de tres y de dos
        ShowEvenNumbers();

    }

    // Funci�n para mostrar los n�meros multiplos de tres y de dos de 0 al 100
    void ShowEvenNumbers()
    {
        Debug.Log("Los n�meros que son multiplos de tres y de dos son: ");
        for (int i = 0; i <= 100; i++)
        {
            // Si el n�mero es multiplo de tres y de dos, lo mostramos
            if (i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log(i);

            }
        }
    }
}
