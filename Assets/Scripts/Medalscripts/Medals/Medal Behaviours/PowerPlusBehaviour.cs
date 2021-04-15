using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MedalCollection.Behaviour
{
    public class PowerPlusBehaviour : MedalBehaviour
    {
        // Start is called before the first frame update
        protected override void Start()
        {
            p_Medal = new MedalCollection.DamagePlus(m_MedalID);
        }
    }
}