using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    public GameObject[] playerWeapons;

    private void Update()
    {
        Movement();

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }

        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            playerWeapons[0].SetActive(false);
        }
    }

    public override void CalculateHP()
    {
        throw new System.NotImplementedException();
    }

    public override void Movement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime *10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 10);
        }
    }
}
