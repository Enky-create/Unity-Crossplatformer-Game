using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrowState : NpcBaseState
{
    public override void EnterState(BaseNpc npc)
    {
    }

    public override void OnCollisionEnter(BaseNpc npc)
    {
    }

    public override void UpdateState(BaseNpc npc)
    {
        var crow = npc as Crow;
        var direction = PlayerController.Instance.controllable.transform.position - crow.transform.position;
        crow.transform.Translate(direction * Time.deltaTime * npc.GetSpeed());
        if (direction.magnitude<npc.GetAttackRadius())
        {
            npc.SwitchState(crow.AttackCrowState);
        }
    }

}
