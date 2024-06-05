using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/StatsBdd")]
public class SO_StatsBdd : ScriptableObject
{
    public string Name;
    public float vida;
    public float maxVida;
    public float atac;
    public float velocitat;
    public float defensa;
    public float critChange;
    public float critDamage;
    public float damagReduction;
}
