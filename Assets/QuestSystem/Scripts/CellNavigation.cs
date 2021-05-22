using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellNavigation : MonoBehaviour
{

    public Cell currentCell;


    Dictionary<string, Cell> exitDictionary = new Dictionary<string, Cell>();

    TextLogController controller;

   
    void Awake()
    {
        controller = GetComponent<TextLogController>();
    }

  

    public void UnpackCellExits()
    {
        for (int i = 0; i < currentCell.exits.Length; i++)
        {
            exitDictionary.Add(currentCell.exits[i].exitDescription, currentCell.exits[i].exitLeadTo);
            controller.exitDescriptions.Add(currentCell.exits[i].exitDescription);
        }
    }

    public void ChangeRooms(string exitText)
    {

        if (exitDictionary.ContainsKey(exitText))
        {

            currentCell = exitDictionary[exitText];
          
            controller.LoadCellDescription();
      
            controller.LoadCellInteractions();
        }
    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }
}
