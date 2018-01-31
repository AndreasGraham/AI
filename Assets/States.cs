using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public enum State
{
   runTo,
   spin,
    
    startoverState //3 basically just number states
}

public class States : MonoBehaviour {

    //WanderBehavior wander;
    //ArriveBehavior arrive;
    //FleeBehavior flee;
    public GameObject target;
   public State currentState;
    NavMeshAgent nav;
    public float transitionTime;
    float timer;

	// Use this for initialization
	void Start () {
        timer = transitionTime;
        nav = GetComponent<NavMeshAgent>();
        //agent = GetComponent<NavMeshAgent>();
        //wander = GetComponent<WanderBehavior>();
        //arrive = GetComponent<ArriveBehavior>();
        //flee = GetComponent<FleeBehavior>();
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case State.runTo:
                nav.destination = target.transform.position;
                break;
            case State.spin:
                transform.Rotate(0, 1, 0);
                break;
        }
        switchStates();
	}
    
    void switchStates()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            currentState++;
            if(currentState == State.startoverState)
            {
                currentState = State.runTo;
            }
            timer = transitionTime;
        }
    }
}
