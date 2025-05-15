using System;
using System.Collections.Generic;
using UnityEngine;
public enum MissionType
{
    First,
    Second,
    Third
}

public enum RewardType
{
    Money,
    Exp
}

[Serializable]
public class MissionData
{
    public int mission_id;
    public int user_id;
    public MissionType mission_type;
    public string description;
    public RewardType reward_type;
    public int reward_amount;
    public int created_at;
    public int completed_at;
}

[ExcelAsset (ExcelName = "DataTable", HeaderRow = 3, DataStartRow = 4, DataStartColumn =1, AssetPath = "Resources", LogOnImport = true)]
public class DataTable : ScriptableObject
{
	public List<MissionData> Sheet1;
}
