using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerEntity
{

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        //Controller.detectCollisions = false;
    }

    // Update is called once per frame
    protected override void Update()
    {
        float moveAD = Input.GetAxis("Horizontal");
        float moveWS = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAD * m_Speed, 0, moveWS * m_Speed);

        // we use "SimpleMove" instead of "Move" because with "Move" gravity won't apply
        Controller.SimpleMove(movement);
    }
}