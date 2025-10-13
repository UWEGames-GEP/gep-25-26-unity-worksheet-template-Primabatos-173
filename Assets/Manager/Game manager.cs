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
        if(state == GameState.GAMEPLAY)
        {
            if(Input.GetKeyDown(KeyCode.P))
            {
                state = GameState.PAUSE;
                haschangedstate = true;
            }
        }
        else if(state == GameState.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                state = GameState.GAMEPLAY;
                haschangedstate = true;
            }
     
        }
        
        
        

    }
    private void LateUpdate()
    {
       


        if (haschangedstate)
        {
            haschangedstate = false;

            if (state == GameState.GAMEPLAY)
            {
                Time.timeScale = 1.0f;
            }
            else if (state == GameState.PAUSE)
            {
                Time.timeScale = 0.0f;
            }
        }
    }
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created

