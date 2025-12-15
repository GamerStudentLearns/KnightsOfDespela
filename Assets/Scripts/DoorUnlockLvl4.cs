using UnityEngine;

public class DoorUnlockLvl4 : MonoBehaviour
{
    public LeverSwitch Lever;
    public LeverSwitch Lever_1;
    public LeverSwitch Lever_2;
    bool DoorOpen = false;
    private void OnTriggerEnter(Collider other)
    {
        if (Lever && !Lever_1 && Lever_2)
        {
            DoorOpen = true;
            Debug.Log("Door Unlocked")
        }
    }
    
        
    
}
