using UnityEngine;
using System.Collections;

public class ToggleTwoArrays : MonoBehaviour
{
    // Drag invisible objects here (they will appear)
    public GameObject[] objectsToAppear;

    // Drag visible objects here (they will disappear)
    public GameObject[] objectsToDisappear;

    // Delay before toggling (seconds)
    public float delay = 3f;

    void Start()
    {
        StartCoroutine(ToggleArrays(delay));
    }

    IEnumerator ToggleArrays(float waitTime)
    {
        // Wait for the variable amount of time
        yield return new WaitForSeconds(waitTime);

        // Make first array appear
        foreach (GameObject obj in objectsToAppear)
        {
            obj.SetActive(true);
        }

        // Make second array disappear
        foreach (GameObject obj in objectsToDisappear)
        {
            obj.SetActive(false);
        }
    }
}


