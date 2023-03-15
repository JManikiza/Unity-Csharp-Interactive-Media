using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{

    NavMeshAgent Creature;
    public GameObject Destination;
    public float MobDistanceRun = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Creature = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        Creature.SetDestination(Destination.transform.position);

    }
}
