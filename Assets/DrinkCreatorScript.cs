using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkCreatorScript : MonoBehaviour
{
    public GameObject sourVisual;
    public GameObject sweetVisual;
    public GameObject sentimentalVisual;
    public GameObject sorrowfulVisual;
    public DrinkContainer endResult;
    public DrinkContainer defaultResult;
    public bool preparationPhase;
    public int sour;
    public int sweet;
    public int sentimental;
    public int sorrowful;
    public int totalIngredients;
    public float moveUpGap;
    float placingPosition;
    public ParticleSystem endResultPoof;
    GameObject[] placedFlavors = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    { 
        placingPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(totalIngredients>=4)
        {
            totalIngredients = 0;
            for(int i=0; i<placedFlavors.Length; i++)
            {
                Destroy(placedFlavors[i]);
            }
            int result = gameObject.GetComponent<RequestComparison>().FindDrinkName(sour, sweet, sorrowful, sentimental);
                if (result == -1)
            {
                endResult = defaultResult;
                
            }
                else
            {
                endResult = gameObject.GetComponent<RequestComparison>().drinkArray[result];
            }
            Instantiate(endResult.drinkModel, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(endResultPoof , new Vector3(0, 0, 0), Quaternion.identity);
            placingPosition = transform.position.y;
            preparationPhase = false;
            toggleDrinkComplete();

        }
    }
    void addSour()
    { if (preparationPhase == true)
        {
            placedFlavors[totalIngredients] = Instantiate(sourVisual, transform.position + new Vector3(0, placingPosition, 0), Quaternion.identity);
            sour++;
            placingPosition += moveUpGap;
            totalIngredients++;
        }
    }
    void addSweet()
    {
        if (preparationPhase == true)
        {

            placedFlavors[totalIngredients] =  Instantiate(sweetVisual, transform.position + new Vector3(0, placingPosition, 0), Quaternion.identity);
            sweet++;
            placingPosition += moveUpGap;
            totalIngredients++;
        }
    }
    void addSentimental()
    {
        if (preparationPhase == true) {
            sentimental++;
            placedFlavors[totalIngredients] =   Instantiate(sentimentalVisual, transform.position + new Vector3(0, placingPosition, 0), Quaternion.identity);
            placingPosition += moveUpGap;
            totalIngredients++;
        }
    }
   void addSorrowful()
    {
        if (preparationPhase == true)
        {
            sorrowful++;
            placedFlavors[totalIngredients] = Instantiate(sorrowfulVisual, transform.position + new Vector3(0, placingPosition, 0), Quaternion.identity);
            
            placingPosition += moveUpGap;
            totalIngredients++;
        }
      
    }
    void beginPreparation()
    {
        preparationPhase = true;
    }
    void toggleDrinkComplete()
    {
        GameObject[] toggledButtons;
        toggledButtons = GameObject.FindGameObjectsWithTag("DrinkToggled");
        for (int i = 0; i <= toggledButtons.Length; i++)
        {
            toggledButtons[i].GetComponent<DrinkMode>().drinkDone = true;
        }

    }
}
