using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestComparison : MonoBehaviour
{
    public int pointsPerSuccess;
    public DrinkContainer[] drinkArray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
  public  int EvaluateDrink(int thisDrinkSour, int thisDrinkSweet, int thisDrinkSorrowful, int thisDrinkSentimental, DrinkContainer thisRequest)
    {
        int awardedPoints = 0;
        if (thisDrinkSour == thisRequest.sour)
        {
            awardedPoints += pointsPerSuccess;

        }
        if (thisDrinkSweet == thisRequest.sweet)
        {
            awardedPoints += pointsPerSuccess;

        }
        if (thisDrinkSorrowful == thisRequest.sorrowful)
        {
            awardedPoints += pointsPerSuccess;

        }
        if (thisDrinkSentimental == thisRequest.sentimental)
        {
            awardedPoints += pointsPerSuccess;

        }
        Debug.Log("Awarded points:" + awardedPoints);
        return awardedPoints;


    }
    public int FindDrinkName(int thisDrinkSour, int thisDrinkSweet, int thisDrinkSorrowful, int thisDrinkSentimental)
    { int foundDrink=-1;

        for (int i = 0; i <= drinkArray.Length; i++)
        {
            if ((thisDrinkSour == drinkArray[i].sour) && (thisDrinkSweet == drinkArray[i].sweet) && (thisDrinkSorrowful == drinkArray[i].sorrowful) && (thisDrinkSentimental == drinkArray[i].sentimental))
            {
                foundDrink = i;
            }
        }
        return foundDrink;

    }
}

