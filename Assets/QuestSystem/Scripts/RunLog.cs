using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RunLog : MonoBehaviour
{

    private string displayedText;
    [SerializeField]
 

    private void Start()
    {
        
    }
    public void RunAction()
    {
        displayedText = GetComponent<Text>().text;
        GetComponentInParent<CellNavigation>().ChangeRooms(displayedText);
        GetComponentInParent<TextLogController>().LogText();

    }



}
