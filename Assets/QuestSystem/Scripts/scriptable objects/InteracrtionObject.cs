using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum CellInteractionType
{
   Charchter,
   Environment
}
[CreateAssetMenu( menuName = "Quest System/ New Interaction")]
public class InteracrtionObject : ScriptableObject
{
    public CellInteractionType type;

}



