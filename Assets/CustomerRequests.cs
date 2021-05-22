using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerRequests : MonoBehaviour
{
    public DrinkContainer[] requests;
    public int pointsPerSuccess=1;
    // Start is called before the first frame update
    void Start() //do this when spawned into the bar!
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int EvaluateDrink(DrinkContainer thisDrink, DrinkContainer thisRequest) 
    {
        int awardedPoints=0;
        if(thisDrink.sour==thisRequest.sour)
        {
            awardedPoints += pointsPerSuccess;

        }
        if (thisDrink.sweet == thisRequest.sweet)
        {
            awardedPoints += pointsPerSuccess;

        }
        if (thisDrink.sorrowful == thisRequest.sorrowful)
        {
            awardedPoints += pointsPerSuccess;

        }
        if (thisDrink.sentimental ==thisRequest.sentimental)
        {
            awardedPoints += pointsPerSuccess;

        }
        Debug.Log("Awarded points:" + awardedPoints);
        return awardedPoints;


    }
}
