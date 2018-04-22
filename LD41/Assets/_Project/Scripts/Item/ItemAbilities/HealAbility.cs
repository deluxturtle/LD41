using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/New ItemAbility")]
public class HealAbility : ItemAbility
{
    public int healAmount = 10;
    public GameObject particleEffect;
    UseItem useItem;

    public override void Initialize(GameObject obj)
    {
        useItem = obj.GetComponent<UseItem>();
        useItem.Initialize();

        useItem.healAmount = healAmount;
        useItem.particleEffect = particleEffect;
    }

    public override void TriggerAbility()
    {
        useItem.Use();
    }
}
