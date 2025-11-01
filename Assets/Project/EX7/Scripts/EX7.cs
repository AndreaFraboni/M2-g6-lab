using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public enum ENEMYSTATE
{
    IDLE,
    AGGROED,
    ATTACKING,
    DEFEATED
}

public enum DAMAGETYPE
{
    SLASHING,
    PIERCING,
    BULDGEONING,
    MAGICAL,
    FORCE
}

public class EX7 : MonoBehaviour
{
    [SerializeField] ENEMYSTATE STATE;

    [SerializeField] private DAMAGETYPE attackType;
    [SerializeField] private DAMAGETYPE resistance;
    [SerializeField] private DAMAGETYPE weakness;
    [SerializeField] private int baseDamage = 100;

    // Start is called before the first frame update
    void Start()
    {

        /*
            baseDamage /= 2;
            Debug.Log("Il nemico è resistente e il valore di baseDamage = " + baseDamage);

        if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log("Il nemico è debole e il valore di baseDamage = " + baseDamage);
        }

        Debug.Log("Il valore di baseDamage = " + baseDamage);
        */

    }

    // Update is called once per frame
    void Update()
    {
        switch (STATE)
        {
            case ENEMYSTATE.IDLE:
                Debug.Log("Il nemico è fermo.");
                break;
            case ENEMYSTATE.AGGROED:
                Debug.Log("Il nemico insegue il giocatore.");
                break;
            case ENEMYSTATE.ATTACKING:
                Debug.Log("Il nemico sta attaccando il giocatore.");
                break;
            case ENEMYSTATE.DEFEATED:
                Debug.Log("Il nemico è sconfitto.");
                break;
        }

    }

}