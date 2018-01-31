using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiPath : MonoBehaviour {

    // Use this for initialization
    NavMeshAgent nav;
    public GameObject dude;
    public GameObject dude2;
    public bool firstCollision;
	void Start () {
        nav = GetComponent<NavMeshAgent>(); // grabs OUR OWN navmesh
        //nav.destination = dude.transform.position; // place in start if you only want it going oneplace, it only updates once (for a recourse or something)
        firstCollision = false;
    }
	
	// Update is called once per frame
	void Update () {
        // nav.destination = dude.transform.position; // .destination takes a vec3
        // place in update if you want him to constantly go towards a moving spot, checked every frame

        if (firstCollision == false)
        {
            nav.destination = dude.transform.position;
        }
        else
        {
            nav.destination = dude2.transform.position;
        }

         }

    
}
