using UnityEngine;

public class DoorUnlockLvl4 : MonoBehaviour
{
    public LeverSwitch Lever;
    public LeverSwitch Lever_1;
    public LeverSwitch Lever_2;

    public GameObject Exit;
    public AudioSource unlockSound; // assign in inspector

    private bool unlocked = false;

    private void Update()
    {
        if (!unlocked && Lever.isOn && !Lever_1.isOn && Lever_2.isOn)
        {
            unlocked = true;
            Exit.SetActive(true); // door activates
            if (unlockSound != null)
            {
                unlockSound.Play(); // play sound once
            }
            Debug.Log("Door Unlocked!");
        }
    }
    
        
    
}
