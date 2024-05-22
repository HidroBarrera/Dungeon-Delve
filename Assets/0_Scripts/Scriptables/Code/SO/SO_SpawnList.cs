using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/SpawnList")]
public class SO_SpawnList : ScriptableObject
{
    public List<GameObject> list = new();
}
