using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeMovement : MonoBehaviour
{

    public int moveSpeed;
    // ^A variable that would change if an ability is used, if an obstacle is encountered or if the character has levelled up

    // Required to make a bool that detects if the character is 'IDLE' or 'BUSY', to determine whether they can engage with the players new inputs.
    // Also need to create a list that will check the status of each character, using a hierarchy to determine the order of which characters will move first.
    // This'd be my attempt to prevent all the characters from moving to the same place when you click. They ought to move one by one, one per click.

    // When clicking on an interactable object, the character should move to a designated tile before engaging.
    // Eg. If you tap a table to take someone's order, the demon should move to either the left or right side of the table before interacting (whichever is closer)
    // Eg. If the demon is using a food station, it must be occupying the tile in front of it and facing the food station.

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
