using UnityEngine;

public class Shop : MonoBehaviour
{

    public int brecol;
    public int patata;
    public int extraBrecol;
    public int extraPatata;
    public bool sumExtras;


    void Sum(int b,int p)
    {

        brecol += b;
        patata += p;

    }

    void Rest(int b, int p)
    {

        brecol -= b;
        patata -= p;

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        if (sumExtras)
        {

            Sum(extraBrecol, extraPatata);

        }
        else
        {

            Rest(extraBrecol, extraPatata);

        }

    }

}
