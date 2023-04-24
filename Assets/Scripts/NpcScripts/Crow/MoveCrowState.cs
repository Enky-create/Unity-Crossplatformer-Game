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
        var direction = PlayerController.Instance.iControllable.GetPosition().position - crow.transform.position;
        crow.transform.Translate(direction * Time.deltaTime * npc.GetSpeed());
        if (direction.magnitude<npc.GetAttackRadius())
        {
            crow.SwitchState(crow.AttackCrowState);
        }
    }

}
