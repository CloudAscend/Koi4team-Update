using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftNPC : NPC
{
    public static Dictionary<int, bool> keyValuePairs = new Dictionary<int, bool>();
    public bool isGift = true;

    [SerializeField]
    int NPCNumber;

    [SerializeField]
    ScriptNPC Gift;
    [SerializeField]
    ScriptNPC Idle;

    private void OnEnable()
    {
        if (!keyValuePairs.TryGetValue(NPCNumber,out isGift))
        {
            keyValuePairs.Add(NPCNumber, true);
            isGift = true;
        }

        Quest = isGift;
    }
    public override void Interaction()
    {
        if (isGift)
        {
            TaikManager.instance.StartTaik(Gift);
            //GiftCode
            Quest = false;
            keyValuePairs[NPCNumber] = false;
            isGift = false;
        }
        else
        {
            TaikManager.instance.StartTaik(Idle);
        }
        //throw new System.NotImplementedException();
    }
}
