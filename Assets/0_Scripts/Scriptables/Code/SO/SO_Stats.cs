using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Stats")]
public class SO_Stats : ScriptableObject
{
    [Header("Global Stats")] 
    public string Name;

    // Variables d'stats
    public float vida;
    public float maxVida;
    public float atac;
    public float velocitat;
    public float defensa;

    // Imatge que farem servir per la llista de torns
    public Sprite imatge;
    public int positionList;

    

    [Header("Player Stats")]
    // Tooltips, quan et poses al d'amunt de una estat amb tooltips mostra el missatge escrit
    public float critChange;
    public float critDamage;
    public float damagReduction;
}
