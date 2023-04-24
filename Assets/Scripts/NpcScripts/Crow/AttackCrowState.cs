using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCrowState : NpcBaseState
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
        var target = PlayerController.Instance.iControllable;
        var direction = target.GetPosition().position - crow.transform.position;
        target.GetDamage(crow.damage*Time.deltaTime * 1);
        if (direction.magnitude > npc.GetAttackRadius())
        {
            npc.SwitchState(crow.MoveCrowState);
        }
    }
}
