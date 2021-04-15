using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MedalCollection;

namespace MedalCollection
{
    public class MedalInventory
    {
        private Dictionary<int, BMedal> p_MedalDic;
        public List<BMedal> MedalList { get; private set; }

        public MedalInventory()
        {
            // set variables
            p_MedalDic = new Dictionary<int, BMedal>();
            MedalList = new List<BMedal>();
        }

        public MedalInventory(params BMedal[] _medals)
        {
            // set variables
            MedalList = new List<BMedal>();
            p_MedalDic = new Dictionary<int, BMedal>();

            // fill variables
            if (!AddMedalToList(out int[] fIndex, _medals))
            {
                Debug.LogWarning("Medal List could not load properly, some IDs were already given.");
            }

        }

        /// <summary>
        /// Add Medal to Medalinventory
        /// </summary>
        /// <param name="_medal">medal to add</param>
        /// <returns>true if medal was added successful, false means a medal with the same ID already got added</returns>
        public bool AddMedal(BMedal _medal)
        {
            return AddMedalToList(out int[] rip, _medal);
        }

        public BMedal GetMedalByID(int _id)
        {
            if (p_MedalDic.ContainsKey(_id))
                return p_MedalDic[_id];
            else
                return null;
        }

        /// <summary>
        /// Add medal to List and to dictionary. 
        /// Also calls <see cref="AddMedalToDictionary(BMedal)"/> with medal ID check. 
        /// This method itself does not have a medal ID check.
        /// </summary>
        /// <param name="_failIndex">if medalID already exists in list, medal won't be added and indexes will be added here (if no error occured, array length will be 0</param>
        /// <param name="_medals">medals to add</param>
        /// <returns>true if no error occured; false means error!</returns>
        private bool AddMedalToList(out int[] _failIndex, params BMedal[] _medals)
        {
            List<int> failindexes = new List<int>();

            // try add each medal
            for (int i = 0; i < _medals.Length; i++)
            {
                // check if medal can be added to Dictionary
                if (AddMedalToDictionary(_medals[i]))
                    MedalList.Add(_medals[i]);

                // Item could not be added, add index to failed numbers
                else
                    failindexes.Add(i);
            }

            _failIndex = failindexes.ToArray();
            return _failIndex.Length == 0;
        }

        /// <summary>
        /// check if Item can be added to Dictionary. 
        /// If item can be added, add it to Dictionary. 
        /// Has medal ID check.
        /// </summary>
        /// <param name="_medal">medal to add</param>
        /// <returns>true if no error occured. false means error!</returns>
        private bool AddMedalToDictionary(BMedal _medal)
        {
            // if medalID is below 0 return false cause of invalid ID;
            if (_medal.GetMedalID < 0)
                return false;
            if (p_MedalDic.ContainsKey(_medal.GetMedalID))
                // Medal ID already exists, return false
                return false;
            else
                p_MedalDic.Add(_medal.GetMedalID, _medal);
            return true;
        }
    }
}
