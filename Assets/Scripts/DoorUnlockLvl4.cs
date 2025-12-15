using UnityEngine;

public class DoorUnlockLvl4 : MonoBehaviour
{
    public LeverSwitch Lever;
    public LeverSwitch Lever_1;
    public LeverSwitch Lever_2;
    public GameObject Exit;

    private bool Unlocked = false;
    
    private void Update()
    {
        if (Unlocked) return;

        if (Lever.isOn && !Lever_1.isOn && Lever_2.isOn)
        {
            Unlocked = true;
            Exit.SetActive(true);
            Debug.Log("Door Unlocked");
        }
    }
}
