using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableSwap_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;

        Debug.Log("Il valore iniziale della variabile a � = " + a + " mentre il valore iniziale della Variabile b � = " + b);

        Debug.Log("facciamo Swap (int n, int m)");
        Swap(a, b);

        Debug.Log("Il valore della variabile a ora � = " + a + " mentre il valore della Variabile b ora � = " + b);
        Debug.Log("lo scambio NON funziona perch� nella funzione lavoriamo su variabili locali senza modificare i valori in memoria delle variabili passate come agomenti della funzione !!!");

        Debug.Log("facciamo Swap (ref int n, ref int m)");
        Swap(ref a, ref b);

        Debug.Log("Il valore della variabile a ora � = " + a + " mentre il valore della Variabile b ora � = " + b);
        Debug.Log("lo scambio funziona perch� all'interno della funzione lavorimao con la reference delle varibili modificando direttamente i valori in memoria !");
    }


    void Swap(int n, int m)
    {
        int o; // variabile di appoggio.
        o = n; // salvo nella variabile di appoggio locale il valore iniziale di n.
        n = m; // assegno a n, variabile locale, il valore di m (b).
        m = o; // assegno a m, variabile locale, il valore di o che era il valore inizile di n (a).
    }

    void Swap(ref int n, ref int m)
    {
        int o; // variabile di appoggio.
        o = n; // salvo nella variabile di appoggio il valore iniziale di n che � collegata direttamente alla variabile a in memoria !!
        n = m; // assegno a n il valore di m che � il valore collegato direttamente alla variabile m =>> b in memoria !!
        m = o; // assegno a m che � direttamente collegata alla variabile b in memoria il valore di o.
    }
}
