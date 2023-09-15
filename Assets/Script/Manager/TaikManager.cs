using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class TaikManager : MonoBehaviour
{
    private static TaikManager m_instance;
    public static TaikManager instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindAnyObjectByType<TaikManager>();
            }
            return m_instance;
        }
    }

    [SerializeField]
    TextMeshProUGUI Name;

    [SerializeField]
    TextMeshProUGUI Script;

    [SerializeField]
    GameObject TextBG;

    bool Taiking = false;
    public bool isTaiking
    {
        get { return Taiking; }
    }
    bool Typing = false;
    int index = 0;
    ScriptNPC NowScript;
    Coroutine Taik;

    private void Update()
    {
        nextText();
    }
    public void StartTaik(ScriptNPC script)
    {
        NowScript = script;
        index = 0;
        Taiking = true;
        Taik = StartCoroutine(TextPrint());
        TextBG.SetActive(true);
    }
    private void nextText()
    {
        if (Taiking)
        {
            if (Input.anyKeyDown)
            {
                if (Typing)
                {
                    StopCoroutine(Taik);
                    Typing = false;
                    Script.text = NowScript.Script[index].Sctipt;
                }
                else
                {
                    index++;
                    if (index == NowScript.Script.Length)
                    {
                        Taiking = false;
                        TextBG.SetActive(false);
                    }
                    else
                    {
                        Taik = StartCoroutine(TextPrint());
                    }
                }
            }
        }
    }
    public IEnumerator TextPrint()
    {

        Name.text = NowScript.Script[index].Name;
        Script.text = string.Empty;
        string script = NowScript.Script[index].Sctipt;
        Typing = true;
        foreach (char c in script)
        {
            Script.text += c;
            yield return new WaitForSeconds(1/ NowScript.TypingSpeed);
        }
        Typing = false;
    }
}
