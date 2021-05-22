using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkMode : MonoBehaviour
{
    public bool drinkDone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((GameObject.Find("TextLog").GetComponent<CellNavigation>().currentCell.drinkRequired)&&(drinkDone==false))
        {
            if (gameObject.GetComponent<Button>().interactable)
            {
                gameObject.GetComponent<Button>().interactable = false;

            }
        }
        else
        {
            if (gameObject.GetComponent<Button>().interactable == false)
            {
                gameObject.GetComponent<Button>().interactable = true;
            }
        }
    }
}
