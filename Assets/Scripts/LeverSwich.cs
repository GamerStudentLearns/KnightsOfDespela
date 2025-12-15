using UnityEngine;

public class LeverSwitch : MonoBehaviour
{
    public bool isOn;
    public Transform leverHandle;
    public float onAngle = -45f;
    public float offAngle = 0f;
    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isOn == true)
            {
                isOn = false;
            }
            else
            {
                isOn = true;
            }
            UpdateLeverVisual();
            Debug.Log("lever switched");
        }
    }

    void UpdateLeverVisual()
    {
        float angle = isOn ? onAngle : offAngle;
        leverHandle.localRotation = Quaternion.Euler(angle, 0f, 0f);
    }
}
