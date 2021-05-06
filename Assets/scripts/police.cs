using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class police : MonoBehaviour
{


    GameObject player;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);

    }
}
