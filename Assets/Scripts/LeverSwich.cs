using UnityEngine;

public class LeverSwitch : MonoBehaviour
{
    bool LeverOn = false;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (LeverOn == true)
            {
                LeverOn = false;
            }
            else
            {
                LeverOn = true;
            }
        }
    }
}
