using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticFunc
{
    private static SO_SpawnList _spawnList;
    public static SO_SpawnList SpawnList { get { return _spawnList; } set { _spawnList = value; } }
    public static void SaveEnemyList(SO_SpawnList list) { SpawnList = list; }
    public static SO_SpawnList ReturnEnemyList() { return SpawnList; }


    private static StatsEditor _statsEditor;
    public static StatsEditor StatsEditor { get { return _statsEditor; } set { _statsEditor = value; } }
    public static void SaveStatsEditor(StatsEditor stats) { StatsEditor = stats; }
    public static StatsEditor ReturnStatsEditor() { return StatsEditor; }
}
