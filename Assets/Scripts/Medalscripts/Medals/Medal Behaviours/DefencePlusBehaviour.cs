using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MedalCollection.Behaviour
{
    public class DefencePlusBehaviour : MedalBehaviour
    {
        protected override void Start()
        {
            p_Medal = new MedalCollection.DefencePlus(m_MedalID);
        }
    }
}