using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSequence : MonoBehaviour
{
    [Header("Number of triggers in puzzle")]
    public int totalTriggers;

    [Header("Objects to activate after all triggers")]
    public GameObject[] objectsToActivate;   // Array of objects

    [Header("Audio Source (attach to same object or prefab)")]
    public AudioSource audioSource;

    private bool[] steppedOn;
    private int steppedCount = 0;

    void Start()
    {
        // Initialize steppedOn array
        steppedOn = new bool[totalTriggers];

        // Deactivate all objects at start
        if (objectsToActivate != null)
        {
            foreach (GameObject obj in objectsToActivate)
            {
                if (obj != null)
                    obj.SetActive(false);
            }
        }

        // Hide audio source until puzzle solved
        if (audioSource != null)
            audioSource.gameObject.SetActive(false);

        // Subscribe to sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        // Unsubscribe to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Reset puzzle state when scene changes
        ResetTriggers();

        // Deactivate objects again
        if (objectsToActivate != null)
        {
            foreach (GameObject obj in objectsToActivate)
            {
                if (obj != null)
                    obj.SetActive(false);
            }
        }

        // Hide audio source again
        if (audioSource != null)
            audioSource.gameObject.SetActive(false);
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
                // Activate all objects
                if (objectsToActivate != null)
                {
                    foreach (GameObject obj in objectsToActivate)
                    {
                        if (obj != null)
                            obj.SetActive(true);
                    }
                }

                // Play audio
                if (audioSource != null)
                {
                    audioSource.gameObject.SetActive(true);
                    audioSource.Play();
                }

                // Reset if you want to reuse puzzle
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
