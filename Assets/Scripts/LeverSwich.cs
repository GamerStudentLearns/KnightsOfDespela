using UnityEngine;

public class LeverSwitch : MonoBehaviour
{

    public bool isOn;
    public Transform leverHandle;
    public float onAngle = -45f;
    public float offAngle = 0f;
    public float rotateSpeed = 5f;

    private bool playerInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = false;
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            isOn = !isOn;
            Debug.Log("Lever switched: " + isOn);
        }

        float targetAngle = isOn ? onAngle : offAngle;
        Quaternion targetRotation = Quaternion.Euler(targetAngle, 0f, 0f);
        leverHandle.localRotation = Quaternion.Lerp(
            leverHandle.localRotation,
            targetRotation,
            Time.deltaTime * rotateSpeed
        );
    }

}
