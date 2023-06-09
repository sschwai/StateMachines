﻿using System.Collections;
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
    private Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
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
    { //State changes
        //Debug.Log(other.name + " entered");
        if (other.name == "WaterTrigger")
        {
            //Debug.Log("Swimming");
            currentState = State.swimming;
        }
        else if (other.name == "MountainTrigger")
        {
            //Debug.Log("Climbing");
            currentState=State.climbing;
        }
    }

    void OnTriggerExit(Collider other)
    { //Stage changes
        //Debug.Log(other.name + " exited");
        //Debug.Log("Walking");
        currentState = State.walking;
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
    { //State changes
        Debug.Log("I am Idle.");
        if (lastPosition != transform.position)
        { //if last position is not current position = movement has occured
            //Debug.Log("Moving");
            currentState = State.walking;
        }
        lastPosition = transform.position; //update position when moving
    }

    void Walking()
    { //Stage changes
        Debug.Log("I am walking!");
        if (lastPosition == transform.position)
        {
            //Debug.Log("Stopped");
            currentState = State.idle;
        }
        lastPosition = transform.position;
    }
}
