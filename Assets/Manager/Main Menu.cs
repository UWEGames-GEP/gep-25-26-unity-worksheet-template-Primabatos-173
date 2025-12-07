using UnityEngine;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Main_menu;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenInventory()
    {
        Inventory.SetActive(true);
        Main_menu.gameObject.SetActive(false);
    }

    
}
