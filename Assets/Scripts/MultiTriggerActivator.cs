using UnityEngine;

public class MultiTriggerActivator : MonoBehaviour
{
    public GameObject objectToActivate;   // The object that will be activated
    public AudioSource audioSource;       // The audio source to play sound
    public Collider[] triggers;           // Array of 3 trigger colliders

    private bool[] triggerStates;         // Track which triggers have been stepped on

    void Start()
    {
        // Initialize trigger states
        triggerStates = new bool[triggers.Length];

        // Ensure object starts inactive
        if (objectToActivate != null)
            objectToActivate.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if player entered one of the triggers
        for (int i = 0; i < triggers.Length; i++)
        {
            if (other == triggers[i])
            {
                triggerStates[i] = true;
                CheckAllTriggers();
            }
        }
    }

    void CheckAllTriggers()
    {
        // If all triggers have been stepped on
        foreach (bool state in triggerStates)
        {
            if (!state) return; // Not all triggered yet
        }

        // Activate object and play sound
        if (objectToActivate != null)
            objectToActivate.SetActive(true);

        if (audioSource != null)
            audioSource.Play();
    }
}

