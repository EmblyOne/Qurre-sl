﻿namespace Qurre.API.Controllers
{
    public class Scp079
    {
        public static int ActivatedGenerators { get; }
        public Camera079[] Camers { get; }
        public Camera079 Camera { get; set; }
        public float MaxEnergy { get; set; }
        public float Energy { get; set; }
        public float Exp { get; set; }
        public string Speaker { get; set; }
        public global::Mirror.SyncListUInt LockedDoors { get; set; }
        public Scp079PlayerScript.Level079[] Lvls { get; set; }
        public Scp079PlayerScript.Ability079[] Abilities { get; set; }
        public bool Is079 { get; }
        public byte Lvl { get; set; }

        public void AddLockedDoor(uint doorID);
        public void ForceLevel(byte levelToForce, bool notifiyUser);
        public void GiveExp(float amount);
        public void UnlockDoor(uint doorID);
        public void UnlockDoors();
    }
}