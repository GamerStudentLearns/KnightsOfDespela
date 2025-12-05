
using UnityEngine;

public class TriggerPlate : MonoBehaviour

{

    [SerializeField] private TriggerActivator activator;

    [SerializeField] private string requiredTag = "PuzzleObject";

    private bool isOccupied = false;

    private void OnTriggerEnter(Collider other)

    {

        if (isOccupied) return;

        if (!other.CompareTag(requiredTag)) return;

        if (activator == null)

        {

            Debug.LogError("❌ TriggerPlate on " + gameObject.name + " has NO Activator assigned!");

            return;

        }

        isOccupied = true;

        activator.AddTrigger();

    }

    private void OnTriggerExit(Collider other)

    {

        if (!isOccupied) return;

        if (!other.CompareTag(requiredTag)) return;

        isOccupied = false;

        activator.RemoveTrigger();

    }

}
