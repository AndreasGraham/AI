using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class archerChan : MonoBehaviour {
   // public float range;
    public GameObject target;
    NavMeshAgent nav;
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        
	}
	
	// Update is called once per frame
	void Update () {
        switchStates();
	}

    void switchStates()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        anim.SetFloat("dist", dist);
    }
}
