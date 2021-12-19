using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Monster/MonsterType", fileName = "NewType")]
public class MonsterType : ScriptableObject
{
    [Header("Typing")]
    public bool Fire;
    public bool Grass;
    public bool Water;
    //[Space]

    [Header("Weaknesses")]
    public bool WeakToFire;
    public bool WeakToGrass;
    public bool WeakToWater;
    //[Space]

    [Header("Resistances")]
    public bool StrongAgainstFire;
    public bool StrongAgainstGrass;
    public bool StrongAgainstWater;
}
