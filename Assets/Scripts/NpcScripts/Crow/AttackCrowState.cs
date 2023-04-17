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
        Debug.Log("Im attacking");
    }
}
