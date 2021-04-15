using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MedalCollection
{
    public class DamagePlus : BPassiveMedal
    {
        public DamagePlus(int _medalId)
            : base(
                "DamagePlus",
                "Increases attack power by 1.",
                _medalId,
                6
                )
        {
            // your constructor goes here
        }
    }
}
