using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MedalCollection.Behaviour
{
    public abstract class MedalBehaviour : BMainScript
    {
        /// <summary>Medal</summary>
        protected BMedal p_Medal;

        [SerializeField]
        protected int m_MedalID;

        protected void OnTriggerEnter(Collider _other)
        {
            if (_other.gameObject.tag == "Player")
            {
                Player p = _other.gameObject.GetComponent<Player>();

                if (p == null)
                {
                    Debug.LogWarning("Object has tag \"Player\" but does not have the \"Player\"-Component", _other.gameObject);
                    Debug.Break();
                }

                bool medalAdded = p.GetMedalInventory.AddMedal(p_Medal);
                if (medalAdded)
                {
                    Debug.Log($"Medal \'{p_Medal}\' added to Inventory");
                }
                else
                {
                    BMedal otherMedal = p.GetMedalInventory.GetMedalByID(p_Medal.GetMedalID);
                    Debug.LogError($"Medal \'{p_Medal}\' could not be added to inventory because the ID already existed: \'{otherMedal}\'.");
                }

                Destroy(this.gameObject);
            }
        }
    }
}
