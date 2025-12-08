using UnityEngine;

public class interaction : MonoBehaviour
{
    bool triggered = false;
    void Update()
    {
        while (triggered)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("rotated:>");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
    }
    private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }

}
