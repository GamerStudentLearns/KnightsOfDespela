using UnityEngine;

public class OnTriggerActivate : MonoBehaviour
{
    // Drag any number of GameObjects into this array in the Inspector
    public GameObject[] objectsToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // only trigger when Player enters
        {
            foreach (GameObject obj in objectsToActivate)
            {
                if (obj != null)
                {
                    obj.SetActive(true); // activate each object
                }
            }
            Debug.Log("Activated " + objectsToActivate.Length + " objects!");
        }
    }
}
