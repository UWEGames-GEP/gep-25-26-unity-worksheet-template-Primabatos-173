using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.MemoryProfiler;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Android;


public class Gamemanager : MonoBehaviour
{
    public enum GameState {PAUSE,GAMEPLAY};
    public GameState state;


    bool haschangedstate = true;
    








    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       switch(state)
        {
            case GameState.GAMEPLAY:
                if(Input.GetKeyDown(KeyCode.P))
                {
                    state = GameState.PAUSE;
                    haschangedstate = true;
                }

                break;

            case GameState.PAUSE:
                if (Input.GetKeyDown(KeyCode.P))
                {
                    state = GameState.GAMEPLAY;
                    haschangedstate = true;
                }
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

