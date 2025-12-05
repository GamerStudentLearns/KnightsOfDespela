using UnityEngine;
public class TriggerSequence : MonoBehaviour
{
    [Header("Number of triggers in puzzle")]
    public int totalTriggers;
    [Header("Object to activate after all triggers")]
    public GameObject objectToActivate;
    [Header("Audio Source (attach to same object or prefab)")]
    public AudioSource audioSource;
    private bool[] steppedOn;
    private int steppedCount = 0;
    void Start()
    {
        steppedOn = new bool[totalTriggers];
        if (objectToActivate != null)
            objectToActivate.SetActive(false);
        if (audioSource != null)
            audioSource.gameObject.SetActive(false); // hide audio source until object appears
    }
    public void TriggerStepped(int index)
    {
        if (!steppedOn[index])
        {
            steppedOn[index] = true;
            steppedCount++;
            // If all triggers have been stepped on
            if (steppedCount >= totalTriggers)
            {
                if (objectToActivate != null)
                    objectToActivate.SetActive(true);
                if (audioSource != null)
                {
                    audioSource.gameObject.SetActive(true); // show audio source only now
                    audioSource.Play();
                }
                // Reset if you want to reuse
                ResetTriggers();
            }
        }
    }
    private void ResetTriggers()
    {
        for (int i = 0; i < steppedOn.Length; i++)
            steppedOn[i] = false;
        steppedCount = 0;
    }
}