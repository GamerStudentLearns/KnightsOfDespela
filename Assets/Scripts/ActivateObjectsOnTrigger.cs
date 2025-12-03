
using UnityEngine;

public class ToggleObjectsOnTrigger : MonoBehaviour
{
    [Header("Objects to Activate")]
    public GameObject[] objectsToActivate;

    [Header("Objects to Deactivate")]
    public GameObject[] objectsToDeactivate;

    [Header("Player Tag")]
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag(playerTag))
        {
            // Activate objects
            foreach (GameObject obj in objectsToActivate)
            {
                if (obj != null)
                    obj.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            // Deactivate objects
            foreach (GameObject obj in objectsToDeactivate)
            {
                if (obj != null)
                    obj.SetActive(false);
            }
        }
    }
}


