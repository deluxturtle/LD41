using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Author: Andrew Seba
/// </summary>
[CreateAssetMenu(fileName = "NewCharacter", menuName = "Characters/Create Character", order = 1)]
public class CharData : ScriptableObject {
    public string firstName;
    public string lastName;
    public uint init = 3;
    public uint strength = 3;
    public uint actionPoints = 2;
    public Sprite profileImage;
    public Material material;//Model
	
}
