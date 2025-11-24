using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterController : ThirdPersonController
{
    public Gamemanager manager;
   

    private void OnPause(InputValue value)
    {
        //press ESC
        if (value.isPressed)
        {
            Debug.Log("pause");
            FindAnyObjectByType<Gamemanager>().Pausefunction();

        }
    }

    private void OnRemoveItem(InputValue value)
    {
        //press Q
        if(value.isPressed)
        {
            Debug.Log("drop item");
            GetComponent<Inventory>().RemoveItemToInventory();
        }
    }




}
