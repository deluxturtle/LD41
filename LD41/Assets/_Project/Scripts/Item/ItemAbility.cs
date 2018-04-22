using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Author: Andrew Seba
/// Description:
/// </summary>
public abstract class ItemAbility : ScriptableObject {

    public string abilityName = "Item Ability";
    public AudioClip sound;
    public uint actionCost = 1;

    public abstract void Initialize(GameObject obj);
    public abstract void TriggerAbility();
}
