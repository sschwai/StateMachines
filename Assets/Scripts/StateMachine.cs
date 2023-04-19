using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "WaterTrigger")
        { Swimming(); }
        else if (other.name == "MountainTrigger")
        { Climbing(); }
    }

    void Swimming()
    {
        Debug.Log("I am swimming!");
    }
    void Climbing()
    {
        Debug.Log("I am climbing!");
    }
}
