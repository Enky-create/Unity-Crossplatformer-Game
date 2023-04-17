using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : BaseNpc
{
    public NpcBaseState AttackCrowState = new AttackCrowState();
    public NpcBaseState MoveCrowState = new MoveCrowState();
    void Start()
    {
        currentState = MoveCrowState;
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }
    public override void Attack()
    {

    }

    public override void Move(Vector2 moveVector)
    {
        transform.position += new Vector3(moveVector.x, moveVector.y, 0f) * Time.deltaTime * moveSpeed;
    }

    public override void SpecialAttack()
    {

    }
}
