using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterController : ThirdPersonController
{
    public Gamemanager manager;
   

    private void OnPause(InputValue value)
    {
        //press E
        if (value.isPressed)
        {
            
            FindAnyObjectByType<Gamemanager>().Pausefunction();

        }
    }

    private void OnRemoveItem(InputValue value)
    {
        //press Q
        if(value.isPressed)
        {
            
           
        }
    }




}
