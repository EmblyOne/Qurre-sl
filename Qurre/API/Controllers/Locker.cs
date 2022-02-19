﻿using MapGeneration.Distributors;
using __locker = MapGeneration.Distributors.Locker;
using Qurre.API.Objects;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using InventorySystem.Items.Pickups;
using KeyPerms = Interactables.Interobjects.DoorUtils.KeycardPermissions;
namespace Qurre.API.Controllers
{
    public class Locker
    {
        internal Locker(__locker locker)
        {
            _locker = locker;
            List<Chamber> list = new();
            foreach (var _ in _locker.Chambers) list.Add(new(_, this));
            Chambers = list.ToArray();
        }
        private readonly __locker _locker;
        public GameObject GameObject => _locker.gameObject;
        public Transform Transform => _locker.transform;
        public __locker GlobalLocker => _locker;
        public string Name => _locker.name;
        public Vector3 Position
        {
            get => Transform.position;
            set
            {
                NetworkServer.UnSpawn(GameObject);
                Transform.position = value;
                NetworkServer.Spawn(GameObject);
            }
        }
        public Quaternion Rotation
        {
            get => Transform.rotation;
            set
            {
                NetworkServer.UnSpawn(GameObject);
                Transform.rotation = value;
                NetworkServer.Spawn(GameObject);
            }
        }
        public Vector3 Scale
        {
            get => Transform.localScale;
            set
            {
                NetworkServer.UnSpawn(GameObject);
                Transform.localScale = value;
                NetworkServer.Spawn(GameObject);
            }
        }
        public LockerLoot[] Loot => _locker.Loot;
        public Chamber[] Chambers { get; private set; }
        public LockerType Type
        {
            get
            {
                return Name switch
                {
                    "Generator SCP-079" => LockerType.Generator,
                    "First Aid Kit" => LockerType.FirstAidKit,
                    "Misc Locker" => LockerType.MiscLocker,
                    "Glocker A" => LockerType.GlockerA,
                    "Glocker B" => LockerType.GlockerB,
                    "Pedestal" => LockerType.Pedestal,
                    _ => LockerType.Unknown,
                };
            }
        }
        public AudioClip GrantedBeep => _locker._grantedBeep;
        public AudioClip DeniedBeep => _locker._deniedBeep;
        public class Chamber
        {
            public LockerChamber LockerChamber { get; private set; }
            public Locker Locker { get; private set; }
            internal Chamber(LockerChamber _chamber, Locker _locker)
            {
                LockerChamber = _chamber;
                Locker = _locker;
            }
            public void SpawnItem(ItemType id, int amount) => LockerChamber.SpawnItem(id, amount);
            public HashSet<ItemPickupBase> ToBeSpawned => LockerChamber._toBeSpawned;
            public bool Opened
            {
                get => LockerChamber.IsOpen;
                set => LockerChamber.SetDoor(value, Locker.GrantedBeep);
            }
            public ItemType[] AcceptableItems
            {
                get => LockerChamber.AcceptableItems;
                set => LockerChamber.AcceptableItems = value;
            }
            public bool CanInteract => LockerChamber.CanInteract;
            public float Cooldown
            {
                get => LockerChamber._targetCooldown;
                set => LockerChamber._targetCooldown = value;
            }
            public KeycardPermissions Permissions
            {
                get => (KeycardPermissions)LockerChamber.RequiredPermissions;
                set => LockerChamber.RequiredPermissions = (KeyPerms)value;
            }
        }
    }
}