using UnityEngine;

public class Week : MonoBehaviour
{

    //  Zona de variables globales
    public int num;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        WeekNumber();

    }


    private void WeekNumber()
    {

        switch (num)
        {

            default:
                Debug.Log("El n�mero introducido no corresponde con los n�meros de la semana");
                break;

            case 1:
                Debug.Log("El d�a de la semana es Lunes");
                break;
            case 2:
                Debug.Log("El d�a de la semana es Martes");
                break;
            case 3:
                Debug.Log("El d�a de la semana es Mi�rcoles");
                break;
            case 4:
                Debug.Log("El d�a de la semana es Jueves");
                break;
            case 5:
                Debug.Log("El d�a de la semana es Viernes");
                break;
            case 6:
                Debug.Log("El d�a de la semana es S�bado");
                break;
            case 7:
                Debug.Log("El d�a de la semana es Domingo");
                break;
        }
    }
}

