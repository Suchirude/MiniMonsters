using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Monster/MonsterMove", fileName = "NewMoveset")]

public class MonsterMove : ScriptableObject
{
    public Moves[] moves;
}

[System.Serializable]
public class Moves 
{
    public int Level;
    public string Attack;
    public int AttackDamage;
}