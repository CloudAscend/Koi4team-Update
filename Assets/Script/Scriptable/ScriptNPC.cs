using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Script", menuName = "Data/Script Data", order = int.MaxValue)]
public class ScriptNPC : ScriptableObject
{
    public float TypingSpeed;
    public bool CanSkip;
        public line[] Script;
        /*public line()
        {
} public line(string text) { }*/
}
[CreateAssetMenu(fileName = "Script", menuName = "Data/asdasd Data", order = int.MaxValue)]
public class Test : ScriptableObject
{
    public float TypingSpeed;
    public bool CanSkip;
    public line[] Script;
    /*public line()
    {
} public line(string text) { }*/
}

[System.Serializable]
public class line
{
    public string Name;
    public string Sctipt;
    public ScreenTransition Transition;

    public enum ScreenTransition
    {
        None,
        FadeOut
    }
}