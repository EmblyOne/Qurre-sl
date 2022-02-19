﻿using InventorySystem.Items.Firearms.Attachments;
using Mirror;
using Mirror.LiteNetLib4Mirror;
using Qurre.API.Objects;
using UnityEngine;
namespace Qurre.API.Controllers
{
    public class WorkStation
    {
        private readonly WorkstationController workStation;
        internal WorkStation(WorkstationController station)
        {
            workStation = station;
        }
        public WorkStation(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            var bench = Object.Instantiate(LiteNetLib4MirrorNetworkManager.singleton.spawnPrefabs.Find(x => x.name == "Work Station"), position, Quaternion.Euler(rotation));
            bench.transform.localScale = scale;
            NetworkServer.Spawn(bench);
            workStation = bench.GetComponent<WorkstationController>();
            Map.WorkStations.Add(this);
        }
        public GameObject GameObject => workStation.gameObject;
        public Transform Transform => GameObject.transform;
        public string Name => GameObject.name;
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
        public Quaternion Rotation
        {
            get => Transform.localRotation;
            set
            {
                NetworkServer.UnSpawn(GameObject);
                Transform.localRotation = value;
                NetworkServer.Spawn(GameObject);
            }
        }
        public Player KnownUser
        {
            get => Player.Get(workStation._knownUser);
            set => workStation._knownUser = value.ReferenceHub;
        }
        public WorkstationStatus Status
        {
            get => (WorkstationStatus)workStation.Status;
            set => workStation.NetworkStatus = (byte)value;
        }
        public bool Activated
        {
            get => Status == WorkstationStatus.Online;
            set => Status = value ? WorkstationStatus.Online : WorkstationStatus.Offline;
        }
        public static WorkStation Create(Vector3 position, Vector3 rotation, Vector3 scale) => new WorkStation(position, rotation, scale);
    }
}