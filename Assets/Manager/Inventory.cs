using NUnit.Framework;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor.Search;
using UnityEngine;
using static Gamemanager;


public class Inventory : MonoBehaviour
{
    Gamemanager gameManager;
    Transform worldItemsTransform;

    private List<Item> items = new List<Item>();
    public Gamemanager manager;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindAnyObjectByType<Gamemanager>();

        Transform worldItemsTransform = GameObject.Find("items").transform;
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

    

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Item collisionItem = hit.gameObject.GetComponent<Item>();

        if (collisionItem != null)
        {
            items.Add(collisionItem);
            collisionItem.gameObject.SetActive(false);
        }
        

    }

    public void AddItemToInventory(Item item)
    {
        items.Add(item);
    }

    public void RemoveItemToInventory()
    {
        if(manager.state == GameState.GAMEPLAY && items.Count > 0)
        {
            Item item = items[0];

            Vector3 currentPossition = transform.position;
            Vector3 forward = transform.forward;

            Vector3 newposition = currentPossition + forward;
            newposition += new Vector3(0, 1, 0);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = currentRotation * Quaternion.Euler(0, 0, 180);

            GameObject newItem = Instantiate(item.gameObject, newposition, newRotation, worldItemsTransform);
            newItem.SetActive(true);

            items.Remove(item);
            Destroy(item.gameObject);
        }





        
    }

}
