using UnityEngine;

public class NoteActivation : MonoBehaviour
{
    GameObject Note;
    public string NoteName;
    private void Awake()
    {
        Note = GameObject.Find(NoteName);
        if (Note == null)
        {
            Debug.Log("object not found");
        }
        Note.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Note.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        Note.SetActive(true);
    }
}
