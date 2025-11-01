using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableSwap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a, b, c; // dichiaro le variabili
        a = 10; // assegno il valore inziale di a
        b = 20; // assegno il valore iniziale di b
        Debug.Log("Il valore della variabile a = " + a + " mentre il valore della Variabile b = " + b);
        Debug.Log("Eseguo lo swap dei valori a e b usando un'altra variabile di appoggio c !!");
        c = b; // salvo valore di b in una variabile di transito.
        b = a; // assegno a b il valore di a.
        a = c; // assegno  ad a il valore che era di b. 
        Debug.Log("Il valore della variabile a = " + a + " mentre il valore della Variabile b = " + b);

    }

}
