using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class StatsEditor : MonoBehaviour
{
    // Mostre tots els stats al UNITY
    [SerializeField] SO_Stats objectStats;

    public string Name { get; private set; }
    // Agafar i modicicar cadescun dels stats
    public float VidaReturnSet { get; set; }
    public float MaxVidaReturnSet { get; private set; }
    public float AtacReturnSet { get; set; }
    public float VelocitatReturnSet { get; set; }
    public float DefensaReturnSet { get; set; }
    public float CritChangeReturnSet { get; set; }
    public float CritDamageReturnSet { get; set; }
    public float DamageReductionReturnSet { get; set; }
    public int PositionList { get; set; }

    void Awake()
    {
        // Passa els valors introduits per l'unity al get/set
        Name = objectStats.Name;
        VidaReturnSet = objectStats.vida;
        MaxVidaReturnSet = objectStats.maxVida;
        AtacReturnSet = objectStats.atac;
        VelocitatReturnSet = objectStats.velocitat;
        DefensaReturnSet = objectStats.defensa;
        CritChangeReturnSet = objectStats.critChange;
        CritDamageReturnSet = objectStats.critDamage;
        DamageReductionReturnSet = objectStats.damagReduction;
    }
    public void GetStats()
    {
        Name = objectStats.Name;
        VidaReturnSet = objectStats.vida;
        MaxVidaReturnSet = objectStats.maxVida;
        AtacReturnSet = objectStats.atac;
        VelocitatReturnSet = objectStats.velocitat;
        DefensaReturnSet = objectStats.defensa;
        CritChangeReturnSet = objectStats.critChange;
        CritDamageReturnSet = objectStats.critDamage;
        DamageReductionReturnSet = objectStats.damagReduction;
    }
}
