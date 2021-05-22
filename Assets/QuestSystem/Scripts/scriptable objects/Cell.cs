using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Quest System/ New Cell")]
public class Cell : ScriptableObject
{

    public string cellName;
    [TextArea]
    public string cellDescription;
    public Image cellImage;
    public Exit[] exits;
    public DrinkContainer requestedDrink;
    public DrinkContainer recievedDrink;
    public bool drinkRequired;
}
[System.Serializable]
public class Exit
{

    [TextArea]
    public string exitDescription;
    public Cell exitLeadTo;

}