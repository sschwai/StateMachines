using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum State
    {
        idle,
        walking,
        swimming,
        climbing
    }

    public State currentState = State.idle; //default state
    void Start()
    {
        
    }

    void Update()
    {
        switch (currentState)
        { 
            case State.idle: Idle(); break;
            case State.walking: Walking();  break;
            case State.swimming: Swimming();  break;
            case State.climbing: Climbing();  break;
            default: break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " entered");
        if (other.name == "WaterTrigger")
        { Swimming(); }
        else if (other.name == "MountainTrigger")
        { Climbing(); }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " exited");
    }

    void Swimming()
    {
        Debug.Log("I am swimming!");
    }
    void Climbing()
    {
        Debug.Log("I am climbing!");
    }

    void Idle()
    {
        Debug.Log("I am Idle.");
    }

    void Walking()
    {
        Debug.Log("I am walking!");
    }
}
