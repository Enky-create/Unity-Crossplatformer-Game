using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseNpc : MonoBehaviour, IControllable
{
    [SerializeField] protected float health;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float attackRadius;
    
    protected NpcBaseState currentState;
    public void SwitchState(NpcBaseState newState)
    {
        currentState = newState;
    }
    public abstract void Attack();

    public abstract void Move(Vector2 moveVector);

    public abstract void SpecialAttack();
    public float GetSpeed()
    {
        return moveSpeed;
    }
    public float GetAttackRadius()
    {
        return attackRadius;
    }
}
