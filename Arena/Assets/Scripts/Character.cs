using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public virtual void Attack()
    {

    }

    public virtual void Defend()
    {

    }

    public abstract void CalculateHP();

    public abstract void Movement();
}
