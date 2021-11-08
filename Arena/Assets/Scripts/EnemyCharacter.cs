using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : Character
{
    private void Awake()
    {
        HitPoints = 1;
        isDead = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            int index = Random.Range(0, 3);
            GameManager.Instance.EnemyCount -= 1;
            GameManager.Instance.DropWeapon(transform.position.x, transform.position.z);
            Destroy(gameObject);
        }        
    }

    public override void CalculateHP()
    {
        throw new System.NotImplementedException();
    }

    public override void Movement()
    {
        throw new System.NotImplementedException();
    }
}
