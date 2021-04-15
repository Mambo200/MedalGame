using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MedalCollection
{
    public abstract class BPassiveMedal : BMedal
    {
        protected BPassiveMedal(string _medalName, string _description, int _medalId, byte _activateCost)
            : base(_medalName, _description, _medalId, _activateCost)
        {

        }
    }
}
