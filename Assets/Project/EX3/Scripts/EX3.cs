using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    [SerializeField] private int dividendo;
    [SerializeField] private int divisore;
    [SerializeField] private int risultato;

    // Start is called before the first frame update
    void Start()
    {
        if (SafeDivide(dividendo, divisore, out risultato))
        {
            Debug.Log("La divisione si può fare ed il risultato è = " + risultato);
        }
        else
        {
            Debug.Log("WARNING : IL DIVISORE NON PUO' ESSERE ZERO !!!!!");
        }
    }

    bool SafeDivide(int dividendo, int divisore, out int risultato)
    {
        if (divisore == 0)
        {
            risultato = 0;
            return false;
        }
        else
        {
            risultato = dividendo / divisore;
            return true;
        }
    }

}
