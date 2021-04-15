using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BAttackMedal : BMedal
{
    protected BAttackMedal(string _medalName, string _description, short _medalId, byte _activateCost, ushort _manaCost)
    : base(
        _medalName,
        _description,
        _medalId,
        _activateCost
        )
    {
        p_UseCost = _manaCost;
    }

    private ushort p_UseCost;
    /// <summary>Says how much energy/mana/we does this medal in Battle cost when activated</summary>
    public ushort GetUseCost { get => p_UseCost; }
}
