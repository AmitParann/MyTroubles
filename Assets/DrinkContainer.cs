using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    [CreateAssetMenu(menuName = "SO/DrinkContainer")]
    public class DrinkContainer : ScriptableObject
    {
    public string drinkName;
    public GameObject drinkModel;
    public Sprite drinkArt;
    public int sour;
    public int sweet;
    public int sentimental;
    public int sorrowful;
    public bool unlocked; //in case we want to archive when player creates it
        [TextArea]
        public string description;
       


    }

