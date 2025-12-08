using UnityEngine;

public class Lvl2puzzle : MonoBehaviour
{
    public bool rotation;
    private void OnTriggerEnter(Collider other)
    {
        rotation = true;
        Debug.Log("correct rotation");
    }
    private void OnTriggerExit(Collider other)
    {
        rotation = false;
        Debug.Log("incorrect rotation");
    }
}
