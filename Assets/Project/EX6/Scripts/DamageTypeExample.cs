using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum DAMAGE_TYPE
{
    SLASHING,
    PIERCING,
    BULDGEONING,
    MAGICAL,
    FORCE
}

public class DamageTypeExample : MonoBehaviour
{
    [SerializeField] private DAMAGE_TYPE attackType;
    [SerializeField] private DAMAGE_TYPE resistance;
    [SerializeField] private DAMAGE_TYPE weakness;
    [SerializeField] private int baseDamage = 100;

    // Start is called before the first frame update
    void Start()
    {
        if (attackType == resistance)
        {
            baseDamage /= 2;
            Debug.Log("Il nemico è resistente e il valore di baseDamage = " + baseDamage);
        }

        if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log("Il nemico è debole e il valore di baseDamage = " + baseDamage);
        }

        Debug.Log("Il valore di baseDamage = " + baseDamage);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
