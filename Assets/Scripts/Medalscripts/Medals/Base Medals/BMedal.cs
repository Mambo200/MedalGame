using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MedalCollection
{
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
        /// Type of Medal
        /// </summary>
        public abstract MedalType GetMedalType { get; }

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

        #region Medal Activation
        /// <summary>
        /// Called when enemy was encountered, but battle did not start yet. 
        /// Calls before <see cref="BattleStart"/>.
        /// </summary>
        public virtual void BeforeBattleStart()
        {

        }

        /// <summary>
        /// Called when battle started.
        /// Calls after <see cref="BeforeBattleStart"/>.
        /// </summary>
        public virtual void BattleStart()
        {

        }

        /// <summary>
        /// Called when one enemy is defeated. 
        /// This is important when battle contains more than one enemy.
        /// </summary>
        public virtual void OneEnemyDefeated()
        {

        }

        /// <summary>
        /// Calls when players turn start
        /// </summary>
        public virtual void StartOfPlayerTurn()
        {

        }

        public virtual void EndOfPlayerTurn()
        {

        }

        public virtual void StartOfPlayerAttack()
        {

        }

        public virtual void EndOfPlayerAttack()
        {

        }

        public virtual void StartOfEnemyTurn()
        {

        }

        public virtual void EndOfEnemyTurn()
        {

        }

        public virtual void StartOfEnemyAttack()
        {

        }

        public virtual void EndOfEnemyAttack()
        {

        }

        public virtual void BattleEnd()
        {

        }

        public virtual void EnterOverworldFromBattle()
        {

        }

        public virtual void OnEquip()
        {

        }

        public virtual void OnUnequip()
        {

        }
        #endregion
    }

    [System.Flags]
    public enum MedalType
    {
        ATTACK = 1 << 0,
        PASSIVE = 1 << 1,
        BATTLESTART = 1 << 2,
        OVERWORLD = 1 << 3
    }
}

