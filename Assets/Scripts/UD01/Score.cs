using UnityEngine;

public class Score : MonoBehaviour
{

    // Zona de variables globales
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Points(score);

    }

    void Points (int n)
    {

        if (n>= 45)
        {
            Debug.Log("Ha superado los 45 puntos");
        }
        else
        {
            Debug.Log("No ha llegado a los 45 puntos");
        }

    }
}
