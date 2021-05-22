using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class TextLogController : MonoBehaviour
{

    [SerializeField]
    private GameObject textTemplate;
  
    [SerializeField]
    private GameObject textParent;
 
    public CellNavigation cellNavigation;
   
    
    [HideInInspector]
    public List<string> exitDescriptions = new List<string>();

    List<GameObject> clones;

    public Color exitTextColor;
    public Color disabledTextColor;
    public Color descriptionTextColor;



    private void Awake()
    {
        cellNavigation = GetComponent<CellNavigation>();
    }


    void Start()
    {  
        clones = new List<GameObject>();
        LogText();
    }



    public void LogText()
    {
        if (clones.Count == 20)
        {
            GameObject tempTextItem = clones[0];
            Destroy(tempTextItem.gameObject);
            clones.Remove(tempTextItem);

        }
        ClearCollectionsForNewCell();
        UnpackCell();
        DisableUnsedIteractions();
        LoadCellDescription();
        LoadCellInteractions();
    }

    
    public void LoadCellDescription()
    {
        string joinedText;
        joinedText = cellNavigation.currentCell.cellName + "\n" + cellNavigation.currentCell.cellDescription;

        GameObject newText = Instantiate(textTemplate);
        newText.GetComponent<Text>().text = joinedText;
        newText.GetComponent<Text>().color = descriptionTextColor;
         newText.transform.SetParent(textParent.transform, false);
        if (gameObject.GetComponent<Button>()!=null)
        {
            gameObject.GetComponent<Button>().enabled = false;
        }
        clones.Add(newText.gameObject);
       
    }


    public void LoadCellInteractions()
    {

        for (int i = 0; i < exitDescriptions.Count; i++)
        {
            GameObject newText = Instantiate(textTemplate);

            newText.GetComponent<Text>().text = exitDescriptions[i];
            newText.GetComponent<Text>().color = exitTextColor;
            newText.transform.SetParent(textParent.transform, false);
            clones.Add(newText.gameObject);

            

        }
    }

    private void UnpackCell()
    {
        cellNavigation.UnpackCellExits();
    }

    void ClearCollectionsForNewCell()
    {
      
        exitDescriptions.Clear();
        cellNavigation.ClearExits();
       


    }

    void DisableUnsedIteractions()
    {
        foreach(GameObject clone in clones)
        {
            clone.GetComponent<Button>().enabled = false;
            clone.GetComponent<Text>().color = disabledTextColor;
        }
    }




}
