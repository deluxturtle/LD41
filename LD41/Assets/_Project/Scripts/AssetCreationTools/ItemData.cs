using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Author: Andrew Seba
/// </summary>
[CreateAssetMenu(fileName = " NewItem", menuName = "Items/New Item", order = 2)]
public class ItemData : ScriptableObject {

    public string itemName;
    public Sprite itemImage;
    public bool stackable = true;
    public ItemAbility ability;
	
}
