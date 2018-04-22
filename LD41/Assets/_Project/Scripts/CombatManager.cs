using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Author: Andrew Seba
/// Description: You can have a team of 3
/// </summary>
public class CombatManager : MonoBehaviour {

    public Transform[] playerSpawns;
    public Transform[] opponentSpawns;

    uint turn = 0;
    List<Person> turnOrder = new List<Person>();

	// Use this for initialization
	void Start ()
    {
		//Get Somepeople
        //Spawn them in


	}

    void DecideTurnOrder(List<Person> people)
    {

        if (people.Count == 0)
        {
            Debug.LogWarning("No people to decide turn order?");
            return;
        }
        else
        {

            people.Sort((x, y) => y.Init.CompareTo(x));
            foreach (Person person in people)
            {
                Debug.Log(person.FirstName);
            }
        }

    }
}
