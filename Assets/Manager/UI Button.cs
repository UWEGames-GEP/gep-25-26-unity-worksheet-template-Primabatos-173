using TMPro;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    public TMP_Text text;

    public void SetButton(Item item)
    {
        text.text = item.itemName;
    }


   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
