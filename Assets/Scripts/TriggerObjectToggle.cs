using UnityEngine;

public class TriggerObjectToggle : MonoBehaviour
{
    [Header("Objects to Activate")]
    public GameObject[] objectsToActivate;

    [Header("Objects to Deactivate")]
    public GameObject[] objectsToDeactivate;

    [Header("Player Tag")]
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            // Activate all in the first array
            foreach (GameObject obj in objectsToActivate)
            {
                if (obj != null)
                    obj.SetActive(true);
            }

            // Deactivate all in the second array
            foreach (GameObject obj in objectsToDeactivate)
            {
                if (obj != null)
                    obj.SetActive(false);
            }
        }
    }
}
