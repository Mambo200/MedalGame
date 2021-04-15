using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MedalCollection
{
    public class DefencePlus : BPassiveMedal
    {
        public DefencePlus(int _medalID)
            : base(
                "Defence Plus",
                "Boosts your defence by 1.",
                _medalID,
                6)
        {

        }
    }
}
