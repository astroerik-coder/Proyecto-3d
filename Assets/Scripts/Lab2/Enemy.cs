using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private  NavMeshAgent agent;
    private Transform player;
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        player = FindObjectOfType<ClickToMove>().transform;
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}
