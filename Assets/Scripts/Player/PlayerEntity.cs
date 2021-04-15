using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(Rigidbody), typeof(CapsuleCollider))]
public abstract class PlayerEntity : BMainScript
{
    public CharacterController Controller { get; private set; }
    public Rigidbody MyRigidbody { get; private set; }

    /// <summary>Players Inventory</summary>
    public MedalInventory GetMedalInventory { get; private set; }

    [SerializeField]
    protected float m_Speed;

    protected override void Start()
    {
        GetMedalInventory = new MedalInventory();

        Controller = GetComponent<CharacterController>();
        MyRigidbody = GetComponent<Rigidbody>();

        base.Start();
    }
}
