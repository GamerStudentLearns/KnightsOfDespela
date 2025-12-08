using System;
using UnityEngine;

public class Lvl2doorunlock : MonoBehaviour
{

    public Lvl2puzzle statue;
    public Lvl2puzzle statue_1;
    public Lvl2puzzle statue_2;

    public bool doorlocked = false;
    void Start()
    {
        var Statue = GameObject.Find("trigger");
        if(Statue != null )
        {
            statue = Statue.GetComponent<Lvl2puzzle>();
            if(statue == null )
            {
                Debug.Log("conponent 1 not found");
            }
        }
        else
        {
            Debug.Log("statue not found");
        }
        var Statue_1 = GameObject.Find("trigger_1");
        if (Statue != null)
        {
            statue_1 = Statue_1.GetComponent<Lvl2puzzle>();
            if (statue_1 == null)
            {
                Debug.Log("conponent 2 not found");
            }
        }
        else
        {
            Debug.Log("statue 1 not found");
        }
        var Statue_2 = GameObject.Find("trigger_1");
        if (Statue != null)
        {
            statue_2 = Statue_2.GetComponent<Lvl2puzzle>();
            if (statue_2 == null)
            {
                Debug.Log("conponent 3 not found");
            }
        }
        else
        {
            Debug.Log("statue 2 not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (statue.rotation && statue_1.rotation && statue_2.rotation)
        {
            doorlocked = true;
            Debug.Log("door unlocked");
        }
        else
        {
            doorlocked = false;
        }
    }
}
