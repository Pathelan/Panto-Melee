using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform target0;
    [SerializeField] private Transform target1;
    [SerializeField] private Transform target2;
    [SerializeField] float destinationReachedThreshold;
    private Transform[] targets; 
    private NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        targets = new Transform[3];

        targets[0] = target0;
        targets[1] = target1;
        targets[2] = target2;

        agent = GetComponent<NavMeshAgent>();

        SelectTarget();
    }

    void SelectTarget()
    {
        int chosenTarget = Random.Range(0, targets.Length);
        agent.destination = new Vector3(targets[chosenTarget].transform.position.x, targets[chosenTarget].transform.position.y, targets[chosenTarget].transform.position.z);
        Debug.Log(targets[chosenTarget]);
    }

    // Update is called once per frame
    void Update()
    {
        agent.velocity = agent.desiredVelocity;
        CheckDestinationReached();
    }

    void CheckDestinationReached()
    {
        float distanceToTarget=Vector3.Distance(transform.position, agent.destination);
        if (distanceToTarget < destinationReachedThreshold)
        {
            print("Destination Reached");
            SelectTarget();
        }
    }

}
