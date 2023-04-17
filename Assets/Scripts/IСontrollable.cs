using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IControllable 
{
    public void Move(Vector2 moveVector);
    public void Attack();
    public void SpecialAttack();
}
