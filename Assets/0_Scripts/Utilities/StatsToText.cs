using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsToText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    [SerializeField] StatsEditor stats;

    private void OnEnable()
    {
        textMeshProUGUI.text = 
            (
                "Nom = " + stats.name + "\r\n" +
                "Vida = " + stats.VidaReturnSet + " VidaMaxima = " + stats.MaxVidaReturnSet + "\r\n" +
                "Atac = " + stats.AtacReturnSet + "\r\n" +
                "Velocitat = " + stats.VelocitatReturnSet + "\r\n" +
                "Defensa = " + stats.DefensaReturnSet + "\r\n" +
                "Percentatge critic = " + stats.CritChangeReturnSet + "\r\n" +
                "Mal critic = " + stats.CritDamageReturnSet + "\r\n" +
                "Reducio de mal = " + stats.DamageReductionReturnSet
            );
    }

}
