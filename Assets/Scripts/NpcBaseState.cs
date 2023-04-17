using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NpcBaseState 
{
    public abstract void EnterState(BaseNpc npc);
    public abstract void UpdateState(BaseNpc npc);
    public abstract void OnCollisionEnter(BaseNpc npc);
}
