using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNPC : NPC
{
    [SerializeField]
    ScriptNPC Script;
    public override void Interaction()
    {
        TaikManager.instance.StartTaik(Script);
        //throw new System.NotImplementedException();
    }
}
