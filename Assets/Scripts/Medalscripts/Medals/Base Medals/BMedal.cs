using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BMedal
{
    protected BMedal(string _medalName, string _description, int _medalId, ushort _activateCost)
    {
        p_Medalname = _medalName;
        p_MedalID = _medalId;
        p_ActivateCosts = _activateCost;

        if (!Initialize())
            throw new System.NotImplementedException("Medal ID can not be below or equal to 0");
    }

    [SerializeField]
    private int p_MedalID = -1;
    public int GetMedalID { get => p_MedalID; }

    [SerializeField]
    private string p_Medalname = "";
    public string GetMedalname { get => p_Medalname; }

    [SerializeField]
    private string p_Description = "";
    public string GetMedalDescription { get => p_Description; }

    /// <summary>Costs to activate this medal</summary>
    [SerializeField]
    private ushort p_ActivateCosts = 0;
    public ushort GetActivcationCosts { get => p_ActivateCosts; }

    /// <summary>
    /// Initialize medal. 
    /// Check if ID is not below 0.
    /// </summary>
    /// <returns>true if everything is correct</returns>
    private bool Initialize()
    {
        return p_MedalID > 0;
    }

    public override string ToString()
    {
        return $"{p_MedalID}:{p_Medalname}";
    }
}
