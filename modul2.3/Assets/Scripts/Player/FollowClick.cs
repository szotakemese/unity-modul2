using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowClick : MonoBehaviour
{
    private Vector3 PositionToMove;
    private bool PositionSelected;
    public float Speed = 10f;

    private NavMeshAgent Agent;

    private void Start()
    {
        Agent = transform.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            PositionSelected = Physics.Raycast(ray, out hit);
            if(PositionSelected){
                PositionToMove = hit.point;
                var selection = hit.transform;
            }
            
        }

        if(PositionSelected)
        {
            Agent.SetDestination(PositionToMove);      
        }
    }
}
