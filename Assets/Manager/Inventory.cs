using NUnit.Framework;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor.Search;
using UnityEngine;
using static Gamemanager;

public class Inventory : MonoBehaviour
{
   private List<string> items = new List<string>();
    public Gamemanager manager;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindAnyObjectByType<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //if(manager.state == GameState.GAMEPLAY)
        {
            //if (Input.GetKeyDown(KeyCode.Q))
            {
                //Additem("item added");
            }
            //if (Input.GetKeyDown(KeyCode.E))
            {
                //Removeitem("item added");
            }
        }
        
    }

    public void Additem(string itemName)
    {
        items.Add(itemName);
    }

    public void Removeitem(string itemName)
    {
        items.Remove(itemName);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        item collisionItem = hit.gameObject.GetComponent<item>();

        if (collisionItem != null)
        {
            items.Add(collisionItem.name);
            Destroy(collisionItem.gameObject);
        }
        

        

    }
}
