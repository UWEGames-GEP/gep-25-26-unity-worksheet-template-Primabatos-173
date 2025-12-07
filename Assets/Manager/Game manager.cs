using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.MemoryProfiler;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Android;


public class Gamemanager : MonoBehaviour
{
    public enum GameState {PAUSE,GAMEPLAY};
    public GameState state;
    public GameObject Inventory_menu;
    public GameObject Main_menu;

    bool haschangedstate = true;
    








    private void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //   switch(state)
    //    {
    //        case GameState.GAMEPLAY:
    //            if(Input.GetKeyDown(KeyCode.P))
    //            {
    //                state = GameState.PAUSE;
    //                haschangedstate = true;
    //            }

    //            break;

    //        case GameState.PAUSE:
    //            if (Input.GetKeyDown(KeyCode.P))
    //            {
    //                state = GameState.GAMEPLAY;
    //                haschangedstate = true;
    //            }
    //            break;
    //        default:
    //            break;
    //    }


        
        
        
        

    //}


    public void Pausefunction()
    {
        switch (state)
        {
            case GameState.GAMEPLAY:

                Cursor.lockState = CursorLockMode.None;
                state = GameState.PAUSE;
                Main_menu.SetActive(true);
                //Inventory_menu.SetActive(true);
                haschangedstate = true;
                

                break;

            case GameState.PAUSE:

                Cursor.lockState = CursorLockMode.Locked;
               state = GameState.GAMEPLAY;
                Main_menu.SetActive(false);
                Inventory_menu.SetActive(false);
                haschangedstate = true;
                
                break;
            default:
                break;
        }
        
    }

    private void LateUpdate()
    {
       


        if (haschangedstate)
        {
            switch (state)
            {
                case GameState.PAUSE:
                    Time.timeScale = 0.0f;
                    break;
                case GameState.GAMEPLAY:
                    Time.timeScale = 1.0f;
                    break;
                default:
                    Time.timeScale = 1.0f;
                    break;
            }
            haschangedstate = false;

            
        }
    }




}
    // Start is called once before the first execution of Update after the MonoBehaviour is created

