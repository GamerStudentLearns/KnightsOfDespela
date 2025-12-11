using UnityEngine;

public class triggertime : MonoBehaviour
{
 public GameObject[] gameObject;

  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject obj in gameObject)
            {
                obj.SetActive(true);
            }
        }
    }
}
