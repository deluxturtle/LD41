using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MouseState
{
    SELECT_CHARACTER,
    WAIT,
    ASSIGN_TARGET,
    FINALIZE
}

/// <summary>
/// Author: Andrew Seba
/// Description: Handles player interactions.
/// </summary>
public class PlayerController : MonoBehaviour {

    public UIManager uiManager;

    Person selectedCharacter;
    Person targetPerson;
    MouseState curState = MouseState.SELECT_CHARACTER;


	// Use this for initialization
	void Start () {
		if(uiManager == null)
        {
            uiManager = FindObjectOfType<UIManager>();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        ExecuteMouse();
	}
    

    void ExecuteMouse()
    {
        if(curState == MouseState.WAIT)
        {
            return;
        }
        //if(curState == MouseState.SELECT_CHARACTER)
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit[] hits = Physics.RaycastAll(ray);
        //    foreach(RaycastHit hit in hits)
        //    {
        //        Person person = hit.collider.GetComponentInParent<Person>();
        //        if (person != null)
        //        {
        //            ChangeSelectedPlayer(person);
        //            //Stay in select character mode. untill starting action.
        //            break;
        //        }
        //    }
        //}
        if(curState == MouseState.ASSIGN_TARGET)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);
            foreach (RaycastHit hit in hits)
            {
                Person person = hit.collider.GetComponentInParent<Person>();
                if (person != null && person != selectedCharacter)
                {
                    targetPerson = person;
                    curState = MouseState.WAIT;
                    break;
                }
            }
        }
    }

    /// <summary>
    /// Handles multiple on change selected player updates.
    /// </summary>
    /// <param name="person"></param>
    private void ChangeSelectedPlayer(Person person)
    {
        selectedCharacter = person;
        uiManager.UpdateName(person.FirstName);
    }

}
