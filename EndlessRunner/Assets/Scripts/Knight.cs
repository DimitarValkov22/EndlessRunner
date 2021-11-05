using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Knight : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    Animator _animator;
    Vector3 _startingPosition;


    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        _startingPosition = transform.position;
    }

    private void OnDisable()
    {
        FindObjectOfType<TEST>().Knights.Remove(item: this);
    }

    void Update() => _animator.SetBool(name: "Walk", value: _navMeshAgent.velocity.magnitude > 0f);

    public void MoveTo(Vector3 position) => _navMeshAgent.SetDestination(position);

    public void ResetPosition()
    {
        transform.position = _startingPosition;
        _navMeshAgent.ResetPath();
    }

    public void Cheer() => _animator.SetTrigger(name: "Cheer");
    
}
