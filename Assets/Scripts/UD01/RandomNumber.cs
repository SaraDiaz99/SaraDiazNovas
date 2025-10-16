using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    public string[] stringArray = new string[5]
    {
        "Vas a morir",
        "Vas a ganar dinero",
        "Vas a encontrar al amor de tu vida",
        "Se va a acabar el mundo",
        "vas a vivir una vida que te encante"

    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log(stringArray[Random.Range(0, 5)]);

    }

}
