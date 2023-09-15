using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class NPC : MonoBehaviour, IInteraction
{
    [SerializeField]
    GameObject Alert;

    protected bool Quest = false;

    [Header("Icon")]
    public Sprite QuestIcon;
    public Sprite IdleIcon;


    private void Update()
    {
        if (Quest)
        {
            Alert.GetComponent<SpriteRenderer>().sprite = QuestIcon;
        }
        else
        {
            Alert.GetComponent<SpriteRenderer>().sprite = IdleIcon;
        }
    }
    public abstract void Interaction();
}
