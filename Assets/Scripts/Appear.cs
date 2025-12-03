using UnityEngine;
using System.Collections;

public class RevealObjects : MonoBehaviour
{
    // Drag your invisible objects here in the Inspector
    public GameObject[] objectsToReveal;

    // Delay before they become visible (seconds)
    public float delay = 3f;

    void Start()
    {
        // Start coroutine to reveal after delay
        StartCoroutine(RevealAfterDelay(delay));
    }

    IEnumerator RevealAfterDelay(float waitTime)
    {
        // Wait for the variable amount of time
        yield return new WaitForSeconds(waitTime);

        // Loop through the array and make them visible
        foreach (GameObject obj in objectsToReveal)
        {
            obj.SetActive(true); // if they were disabled
            // Alternatively, if you only want to toggle visibility:
            // obj.GetComponent<Renderer>().enabled = true;
        }
    }
}

