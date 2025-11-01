using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum STATE
{
    IDLE,
    AGGROED,
    ATTACKING,
    DEFEATED
}

public class EnemySwitchBehaviour : MonoBehaviour
{
    [SerializeField] STATE STATE; // dichiarazione variabile di tipo STATE che è un enum dichiarato sopra.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (STATE == STATE.IDLE)
        {
            Debug.Log("Il nemico è fermo.");
        }
        else if (STATE == STATE.AGGROED)
        {
            Debug.Log("Il nemico insegue il giocatore.");
        }
        else if (STATE == STATE.ATTACKING)
        {
            Debug.Log("Il nemico sta attaccando il giocatore.");
        }
        else if (STATE == STATE.DEFEATED)
        {
            Debug.Log("Il nemico è sconfitto.");
        }
    }
}
