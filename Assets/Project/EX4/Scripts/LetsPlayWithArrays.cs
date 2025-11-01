using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    [SerializeField] private int[] array;             // dichiaro un array accessibile in inspector.
    [SerializeField] private int numerodacercare = 3; // numero da cercare nell'array.
    [SerializeField] private int[] arrayToBack;   // dichiaro array risultato della modifica dellas funzione PutToTheBack !!!

    // Start is called before the first frame update
    void Start()
    {
        array = GeneraArray(10);
        arrayToBack = GeneraArray(10);
        arrayToBack = array;

        int indiceelemento = Find(array, numerodacercare); // cerco l'indice dell'elemento dell'array che contiene il numero indicato in numerodacercare !!!
        Debug.Log("Il numero : " + numerodacercare + " si trova nell'array all'indice => " + indiceelemento);

        PutToTheBack(ref arrayToBack, indiceelemento);

    }

    int[] GeneraArray(int dimensioni)
    {
        array = new int[dimensioni];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1; // assegno un numero nell'array all'indice corrente.
        }

        return array;
    }

    int Find(int[] array, int value)
    {
        int indice = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value) indice = i;
        }
        return indice;
    }

    void PutToTheBack(ref int[] array, int index)
    {
        int backupelement;                              // dichiaro variabile locale di backup per salvare l'elemento che troverò all'indice indicato.
        backupelement = array[index];                   // salvo il valore dell'elemento posizionato all'indice indicato.
        int[] newarray = new int[array.Length];         // creo array di supporto.
        newarray[(array.Length - 1)] = backupelement;   // metto l'elemento trovato all'indice indicato come ultimo elemento dell'array di supporto.

        int nindex = 0;                                 // indice dell'array di supporto.

        for (int i = 0; i < array.Length; i++)          // ciclo for che itera nell'array da modificare
        {
            if (i != index)                             // se la variabile indice dell'array da modificare è diverso dall'indice dell'elemento spostato nell'array di supporto vai avanti.
            {
                if (nindex < newarray.Length - 1)       // se sono nei limiti dell'array di supporto proseguo.
                {
                    newarray[nindex] = array[i];        // assegno l'elemento dell'array di partenza all'elemento dell'array di supporto.
                    nindex++;                           // incremento index dell'array di supporto.
                }
            }
        }

        array = newarray; // modifico l'array direttamente in memoria con il contenuto dell'array di supporto newarray
    }

}
