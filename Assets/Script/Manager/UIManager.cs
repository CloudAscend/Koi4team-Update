using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventory;
    private bool inventoryOpen = false;
    private UIManager m_instance;
    public UIManager instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindAnyObjectByType<UIManager>();
            }
            return m_instance;
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            inventoryOpen = !inventoryOpen;
            Iventory(inventoryOpen);
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (inventoryOpen)
            {
                inventoryOpen = !inventoryOpen;
                Iventory(inventoryOpen);
            }
        }
    }
    public void Iventory(bool Active)
    {
        inventory.SetActive(Active);
        Time.timeScale= Active ? 0 : 1;
    }
}
