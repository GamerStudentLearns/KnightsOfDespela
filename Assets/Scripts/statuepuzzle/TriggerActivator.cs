using UnityEngine;
public class TriggerActivator : MonoBehaviour
{
    [Header("Trigger Settings")]
    public int requiredTriggerCount = 1;
    private int currentTriggerCount = 0;
    [Header("Activation Target")]
    public GameObject objectToActivate;
    [Header("Sound")]
    public AudioSource activationSound;   // Drag an AudioSource here
    private bool hasPlayedSound = false;  // Prevents sound spam
    public void AddTrigger()
    {
        currentTriggerCount++;
        Debug.Log("Trigger Added: " + currentTriggerCount);
        Check();
    }
    public void RemoveTrigger()
    {
        currentTriggerCount--;
        Debug.Log("Trigger Removed: " + currentTriggerCount);
        Check();
    }
    private void Check()
    {
        if (objectToActivate == null) return;
        // ✅ ACTIVATE
        if (currentTriggerCount >= requiredTriggerCount)
        {
            objectToActivate.SetActive(true);
            if (!hasPlayedSound && activationSound != null)
            {
                activationSound.Play();
                hasPlayedSound = true;
            }
        }
        // ❌ DEACTIVATE
        else
        {
            objectToActivate.SetActive(false);
            hasPlayedSound = false; // Allows sound to play again if reactivated
        }
    }
}