using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Author: Andrew Seba
/// </summary>
public class Person : MonoBehaviour{

    public Transform model;

    string firstName;
    uint init = 5;
    uint strength = 5;

    public void SetCharacterData(CharData charData)
    {
        FirstName = charData.firstName;
        Init = charData.init;
        strength = charData.strength;
        foreach(Transform child in model)
        {
            child.GetComponent<Renderer>().material = charData.material;
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }

    public uint Init
    {
        get
        {
            return init;
        }
        set
        {
            init = value;
        }
    }

    public uint Strength
    {
        get
        {
            return strength;
        }
        set
        {
            strength = value;
        }
    }

}
