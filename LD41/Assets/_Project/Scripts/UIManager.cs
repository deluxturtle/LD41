using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Author: Andrew Seba
/// Description:
/// </summary>
public class UIManager : MonoBehaviour {

    public Text selectedPlayerLabel;

	public void UpdateName(string name)
    {
        selectedPlayerLabel.text = name;
    }
}
