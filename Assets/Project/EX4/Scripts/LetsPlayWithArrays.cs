using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    [SerializeField] private int[] array;             // dichiaro un array accessibile in inspector.
    [SerializeField] private int numerodacercare = 3; // numero da cercare nell'array.
    [SerializeField] private int[] arrayToBack;       // dichiaro array risultato della modifica della funzione PutToTheBack !!!
    [SerializeField] private int[] arrayShiftOnce;    // dichiaro array risultato della modifica della funzione ShiftOnce !!!
    [SerializeField] private int[] arrayShiftTimes;   // dichiaro array risultato della modifica della funzione ShiftTimes !!!

    // Start is called before the first frame update
    void Start()
    {
        array = GeneraArray(10);
        arrayToBack = GeneraArray(10);
        arrayToBack = array;
        arrayShiftOnce = array;
        arrayShiftTimes = array;

        int indiceelemento = Find(array, numerodacercare); // cerco l'indice dell'elemento dell'array che contiene il numero indicato in numerodacercare !!!
        Debug.Log("Il numero : " + numerodacercare + " si trova nell'array all'indice => " + indiceelemento);

        PutToTheBack(ref arrayToBack, indiceelemento);
        ShiftOnce(ref arrayShiftOnce);
        Shift(ref arrayShiftTimes, 3);

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
        int[] newarray = new int[array.Length];         // creo array di supporto come l'array da modificare.

        backupelement = array[index];                   // salvo il valore dell'elemento posizionato all'indice indicato.
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

    void ShiftOnce(ref int[] array)
    {
        int backupelement;                              // dichiaro variabile locale di backup per salvare l'ultimo elemento dell'array.
        int[] newarray = new int[array.Length];         // creo array di supporto come l'array da modificare.

        backupelement = array[array.Length - 1];          // salvo il valore dell'ultimo elemento dell'array da modificare.
        newarray[0] = backupelement;                    // metto l'elemento salvato come primo elemento dell'array di supporto.

        int nindex = 1;                                 // indice di partenza dell'array di supporto.

        for (int i = 0; i < array.Length; i++)      // ciclo for che itera nell'array da modificare escludendo l'ultimo elemento.
        {
            if (nindex < newarray.Length)           // se sono nei limiti dell'array di supporto proseguo.
            {
                newarray[nindex] = array[i];            // assegno l'elemento dell'array di partenza all'elemento dell'array di supporto.
                nindex++;                               // incremento index dell'array di supporto.
            }
        }

        array = newarray; // modifico l'array direttamente in memoria con il contenuto dell'array di supporto newarray
    }


    void Shift(ref int[] array, int times)
    {
        for (int i = 0; i < times; i++) // faccio eseguire un numero di times volte la funzione ShiftOnce.
        {
            ShiftOnce(ref array);
        }
    }

}
