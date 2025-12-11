using UnityEngine;

public class ActivateObjectsOnTrigger : MonoBehaviour

{

    [Header("Player must enter ALL of these triggers")]

    public Collider[] triggerZones;

    [Header("Objects that will activate AFTER all triggers are entered")]

    public GameObject[] objectsToActivate;

    [Header("Sound to play when activation happens")]

    public AudioClip activationSound;

    private AudioSource audioSource;

    private bool[] triggered;

    private int triggersEntered = 0;

    public string playerTag = "Player";

    void Start()

    {

        triggered = new bool[triggerZones.Length];

        // Add trigger listeners

        for (int i = 0; i < triggerZones.Length; i++)

        {

            TriggerListener_All t = triggerZones[i].gameObject.AddComponent<TriggerListener_All>();

            t.Setup(this, i);

        }

        // Prepare audio source

        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;

    }

    public void OnTriggerEntered(int index)

    {

        if (!triggered[index])

        {

            triggered[index] = true;

            triggersEntered++;

            // When ALL triggers have been entered

            if (triggersEntered == triggerZones.Length)

            {

                ActivateAllObjects();

            }

        }

    }

    private void ActivateAllObjects()

    {

        // Activate all assigned objects

        foreach (GameObject obj in objectsToActivate)

        {

            obj.SetActive(true);

        }

        // Play sound once

        if (activationSound != null)

        {

            audioSource.PlayOneShot(activationSound);

        }

    }

}


// Helper listener

public class TriggerListener_All : MonoBehaviour

{

    private ActivateAfterAllTriggers manager;

    private int index;

    public void Setup(ActivateAfterAllTriggers m, int i)

    {

        manager = m;

        index = i;

    }

    private void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag(manager.playerTag))

        {

            manager.OnTriggerEntered(index);

        }

    }

}

