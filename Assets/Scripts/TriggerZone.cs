using UnityEngine;
public class TriggerZone : MonoBehaviour
{
    public int triggerIndex; // set in Inspector
    public TriggerSequence manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.TriggerStepped(triggerIndex);
        }
    }
}
