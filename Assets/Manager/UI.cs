using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Inventory inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();

    private void OnEnable()
    {
        RefreshInventory();
    }

    
    void RefreshInventory()
    {
        //disable each inventory ui button's game object
        foreach (GameObject uiButton in inventoryUIButtons)
        {
            uiButton.SetActive(false);
        }

        for (int i = 0; i < inventory.items.Count; i++)
        {
            if(i < inventoryUIButtons.Count)
            {
                //create a reference to the ui buttons and items
                UIButton uiButton = inventoryUIButtons[i].GetComponent<UIButton>();
                Item item = inventory.items[i];

                uiButton.gameObject.SetActive(true);
                uiButton.SetButton(item);

            }
        }


        Debug.Log("Refresh");
    }

    public void OnInventoryUIButton(int i)
    {
        inventory.RemoveItemFromInventory(i);
        RefreshInventory();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
