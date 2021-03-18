﻿using System;
using System.Collections.Generic;
namespace Qurre.API.Events
{
    public class BlinkEvent : EventArgs
    {
        public BlinkEvent(HashSet<Player> players);

        public HashSet<Player> Players { get; }
    }
    public class UpgradeEvent : EventArgs
    {
        public UpgradeEvent(global::Scp914.Scp914Machine scp914, List<Player> players, List<Pickup> items, global::Scp914.Scp914Knob knob, bool allowed = true);

        public global::Scp914.Scp914Machine Scp914 { get; }
        public List<Player> Players { get; }
        public List<Pickup> Items { get; }
        public global::Scp914.Scp914Knob Knob { get; set; }
        public bool Allowed { get; set; }
    }
    public class ChangeKnobEvent : EventArgs
    {
        public ChangeKnobEvent(Player player, global::Scp914.Scp914Knob knobSetting, bool allowed = true);

        public Player Player { get; }
        public global::Scp914.Scp914Knob KnobSetting { get; set; }
        public bool Allowed { get; set; }
    }
    public class ActivatingEvent : EventArgs
    {
        public ActivatingEvent(Player player, double duration, bool allowed = true);

        public Player Player { get; }
        public double Duration { get; set; }
        public bool Allowed { get; set; }
    }
    public class TeamRespawnEvent : EventArgs
    {
        public TeamRespawnEvent(List<Player> players, int maxRespAmount, global::Respawning.SpawnableTeamType nextKnownTeam);

        public List<Player> Players { get; }
        public int MaxRespAmount { get; set; }
        public global::Respawning.SpawnableTeamType NextKnownTeam { get; set; }
    }
    public class RoundEndEvent : EventArgs
    {
        public RoundEndEvent(RoundSummary.LeadingTeam leadingTeam, RoundSummary.SumInfo_ClassList classList, int toRestart);

        public RoundSummary.LeadingTeam LeadingTeam { get; }
        public RoundSummary.SumInfo_ClassList ClassList { get; set; }
        public int ToRestart { get; set; }
    }
    public class PortalUsingEvent : EventArgs
    {
        public PortalUsingEvent(Player player, global::UnityEngine.Vector3 portalPosition, bool allowed = true);

        public Player Player { get; }
        public global::UnityEngine.Vector3 PortalPosition { get; set; }
        public bool Allowed { get; set; }
    }
    public class CheckEvent : EventArgs
    {
        public CheckEvent(RoundSummary.LeadingTeam leadingTeam, RoundSummary.SumInfo_ClassList classList, bool roundEnd);

        public RoundSummary.LeadingTeam LeadingTeam { get; set; }
        public RoundSummary.SumInfo_ClassList ClassList { get; set; }
        public bool RoundEnd { get; set; }
    }
    public class TeslaTriggerEvent : EventArgs
    {
        public TeslaTriggerEvent(Player player, bool inHurtingRange, bool triggerable = true);

        public Player Player { get; }
        public bool InHurtingRange { get; set; }
        public bool Triggerable { get; set; }
    }
    public class ThrowGrenadeEvent : EventArgs
    {
        public ThrowGrenadeEvent(Player player, global::Grenades.GrenadeManager grenadeManager, int id, bool slow, double fuseTime, bool allowed = true);

        public Player Player { get; }
        public global::Grenades.GrenadeManager GrenadeManager { get; }
        public int Id { get; }
        public bool Slow { get; set; }
        public double FuseTime { get; set; }
        public bool Allowed { get; set; }
    }
    public class SyncDataEvent : EventArgs
    {
        public SyncDataEvent(Player player, global::UnityEngine.Vector2 speed, byte currentAnimation, bool allowed = true);

        public Player Player { get; }
        public global::UnityEngine.Vector2 Speed { get; }
        public byte CurrentAnimation { get; set; }
        public bool Allowed { get; set; }
    }
    public class MedicalStoppingEvent : MedicalUsingEvent
    {
        public MedicalStoppingEvent(Player player, ItemType item, float cooldown, bool allowed = true);

        public float Cooldown { get; }
    }
    public class MedicalUsingEvent : MedicalUsedEvent
    {
        public MedicalUsingEvent(Player player, ItemType item, float cooldown, bool allowed = true);

        public float Cooldown { get; set; }
        public bool Allowed { get; set; }
    }
    public class MedicalUsedEvent : EventArgs
    {
        public MedicalUsedEvent(Player player, ItemType item);

        public Player Player { get; }
        public ItemType Item { get; }
    }
    public class SpawnEvent : EventArgs
    {
        public SpawnEvent(Player player, RoleType roleType, global::UnityEngine.Vector3 position, float rotationY);

        public Player Player { get; }
        public RoleType RoleType { get; }
        public global::UnityEngine.Vector3 Position { get; set; }
        public float RotationY { get; set; }
    }
    public class RagdollSpawnEvent : EventArgs
    {
        public RagdollSpawnEvent(Player killer, Player owner, Ragdoll ragdoll, bool allowed = true);

        public Player Killer { get; }
        public Player Owner { get; }
        public Ragdoll Ragdoll { get; }
        public bool Allowed { get; set; }
    }
    public class PortalCreateEvent : EventArgs
    {
        public PortalCreateEvent(Player player, global::UnityEngine.Vector3 position, bool allowed = true);

        public Player Player { get; }
        public global::UnityEngine.Vector3 Position { get; set; }
        public bool Allowed { get; set; }
    }
    public class FemurBreakerEnterEvent : EventArgs
    {
        public FemurBreakerEnterEvent(Player player, bool allowed = true);

        public Player Player { get; }
        public bool Allowed { get; set; }
    }
    public class SendingConsoleEvent : EventArgs
    {
        public SendingConsoleEvent(Player player, string message, string name, string[] args, bool isEncrypted, string returnMessage = "", string color = "white", bool allowed = true);

        public Player Player { get; }
        public string Message { get; }
        public string Name { get; }
        public string[] Args { get; }
        public bool IsEncrypted { get; }
        public string ReturnMessage { get; set; }
        public string Color { get; set; }
        public bool Allowed { get; set; }
    }
    public class SendingRAEvent : EventArgs
    {
        public string pref;

        public SendingRAEvent(CommandSender commandSender, Player player, string command, string name, string[] args, string prefix = "", bool allowed = true);

        public CommandSender CommandSender { get; }
        public Player Player { get; }
        public string Command { get; }
        public string Name { get; }
        public string[] Args { get; }
        public string ReplyMessage { get; set; }
        public string Prefix { get; set; }
        public bool Success { get; set; }
        public bool Allowed { get; set; }
    }
    public class FinishRecallEvent : StartRecallEvent
    {
        public FinishRecallEvent(Player scp049, Player target, bool allowed = true);
    }
    public class StartRecallEvent : EventArgs
    {
        public StartRecallEvent(Player scp049, Player target, bool allowed = true);

        public Player Scp049 { get; }
        public Player Target { get; }
        public bool Allowed { get; set; }
    }
    public class GetLVLEvent : EventArgs
    {
        public GetLVLEvent(Player player, int oldLevel, int newLevel, bool allowed = true);

        public Player Player { get; }
        public int OldLevel { get; }
        public int NewLevel { get; set; }
        public bool Allowed { get; set; }
    }
    public class GetEXPEvent : EventArgs
    {
        public GetEXPEvent(Player player, ExpGainType type, float amount, bool allowed = true);

        public Player Player { get; }
        public ExpGainType Type { get; }
        public float Amount { get; set; }
        public bool Allowed { get; set; }
    }
    public class ContainEvent : EventArgs
    {
        public ContainEvent(Player player, bool allowed = true);

        public Player Player { get; }
        public bool Allowed { get; set; }
    }
    public class RecontainEvent : EventArgs
    {
        public RecontainEvent(Player target);

        public Player Target { get; }
    }
    public class AddTargetEvent : EventArgs
    {
        public AddTargetEvent(global::PlayableScps.Scp096 scp096, Player target, bool allowed = true);

        public global::PlayableScps.Scp096 Scp096 { get; }
        public Player Target { get; }
        public bool Allowed { get; set; }
    }
    public class CalmDownEvent : EnrageEvent
    {
        public CalmDownEvent(global::PlayableScps.Scp096 scp096, Player player, bool allowed = true);
    }
    public class EnrageEvent : EventArgs
    {
        public EnrageEvent(global::PlayableScps.Scp096 scp096, Player player, bool allowed = true);

        public global::PlayableScps.Scp096 Scp096 { get; }
        public Player Player { get; }
        public bool Allowed { get; set; }
    }
    public class PocketDimensionFailEscapeEvent : EventArgs
    {
        public PocketDimensionFailEscapeEvent(Player player, PocketDimensionTeleport teleporter, bool allowed = true);

        public Player Player { get; }
        public PocketDimensionTeleport Teleporter { get; }
        public bool Allowed { get; set; }
    }
    public class PocketDimensionEscapeEvent : EventArgs
    {
        public PocketDimensionEscapeEvent(Player player, global::UnityEngine.Vector3 teleportPosition, bool allowed = true);

        public Player Player { get; }
        public global::UnityEngine.Vector3 TeleportPosition { get; set; }
        public bool Allowed { get; set; }
    }
    public class PocketDimensionEnterEvent : EventArgs
    {
        public PocketDimensionEnterEvent(Player player, global::UnityEngine.Vector3 position, bool allowed = true);

        public Player Player { get; }
        public global::UnityEngine.Vector3 Position { get; set; }
        public bool Allowed { get; set; }
    }
    public class GeneratorActivateEvent : EventArgs
    {
        public GeneratorActivateEvent(Generator generator);

        public Generator Generator { get; }
    }
    public class SpeakEvent : EventArgs
    {
        public SpeakEvent(global::Assets._Scripts.Dissonance.DissonanceUserSetup userSetup, bool icom, bool radio, bool mimicAs939, bool scpChat, bool ripChat, bool allowed = true);

        public global::Assets._Scripts.Dissonance.DissonanceUserSetup UserSetup { get; }
        public bool Intercom { get; }
        public bool Radio { get; }
        public bool MimicAs939 { get; }
        public bool ScpChat { get; }
        public bool RipChat { get; }
        public bool Allowed { get; set; }
    }
    public class ShootingEvent : EventArgs
    {
        public ShootingEvent(Player shooter, global::UnityEngine.GameObject target, global::UnityEngine.Vector3 position, bool allowed = true);

        public Player Shooter { get; }
        public global::UnityEngine.GameObject Target { get; }
        public global::UnityEngine.Vector3 Position { get; set; }
        public bool Allowed { get; set; }
    }
    public class RechargeWeaponEvent : EventArgs
    {
        public RechargeWeaponEvent(Player player, bool animationOnly, bool allowed = true);

        public Player Player { get; }
        public bool AnimationOnly { get; }
        public bool Allowed { get; set; }
    }
    public class GroupChangeEvent : EventArgs
    {
        public GroupChangeEvent(Player player, UserGroup newGroup, bool allowed = true);

        public Player Player { get; }
        public UserGroup NewGroup { get; set; }
        public bool Allowed { get; set; }
    }
    public class KickedEvent : EventArgs
    {
        public KickedEvent(Player player, string reason, bool allowed = true);

        public Player Player { get; }
        public string Reason { get; set; }
        public bool Allowed { get; set; }
    }
    public class KickEvent : EventArgs
    {
        public KickEvent(Player target, Player issuer, string reason, string fullMessage, bool allowed = true);

        public Player Target { get; set; }
        public Player Issuer { get; set; }
        public string Reason { get; set; }
        public string FullMessage { get; set; }
        public bool Allowed { get; set; }
    }
    public class BanEvent : KickEvent
    {
        public BanEvent(Player target, Player issuer, int duration, string reason, string fullMessage, bool allowed = true);

        public int Duration { get; set; }
    }
    public class BannedEvent : EventArgs
    {
        public BannedEvent(Player player, BanDetails details, BanHandler.BanType type);

        public Player Player { get; }
        public BanDetails Details { get; }
        public BanHandler.BanType Type { get; }
    }
    public class EnableAlphaPanelEvent : EventArgs
    {
        public EnableAlphaPanelEvent(Player player, List<string> permissions, bool allowed = true);

        public Player Player { get; }
        public List<string> Permissions { get; }
        public bool Allowed { get; set; }
    }
    public class ItemChangeEvent : EventArgs
    {
        public ItemChangeEvent(Player player, Inventory.SyncItemInfo oldItem, Inventory.SyncItemInfo newItem);

        public Player Player { get; }
        public Inventory.SyncItemInfo OldItem { get; set; }
        public Inventory.SyncItemInfo NewItem { get; }
    }
    public class AlphaStopEvent : EventArgs
    {
        public AlphaStopEvent(Player player, bool allowed = true);

        public Player Player { get; }
        public bool Allowed { get; set; }
    }
    public class GrenadeExplodeEvent : EventArgs
    {
        public GrenadeExplodeEvent(Player thrower, Dictionary<Player, float> targetToDamages, bool isFrag, global::UnityEngine.GameObject grenade, bool allowed = true);

        public Player Thrower { get; }
        public Dictionary<Player, float> TargetToDamages { get; }
        public List<Player> Targets { get; }
        public bool IsFrag { get; }
        public global::UnityEngine.GameObject Grenade { get; }
        public bool Allowed { get; set; }
    }
    public class NewDecalEvent : EventArgs
    {
        public NewDecalEvent(Player owner, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, int type, bool allowed = true);

        public Player Owner { get; }
        public global::UnityEngine.Vector3 Position { get; set; }
        public global::UnityEngine.Quaternion Rotation { get; set; }
        public int Type { get; set; }
        public bool Allowed { get; set; }
    }
    public class NewBloodEvent : EventArgs
    {
        public NewBloodEvent(Player player, global::UnityEngine.Vector3 position, int type, float multiplier, bool allowed = true);

        public Player Player { get; }
        public global::UnityEngine.Vector3 Position { get; set; }
        public int Type { get; set; }
        public float Multiplier { get; set; }
        public bool Allowed { get; set; }
    }
    public class MTFAnnouncementEvent : EventArgs
    {
        public MTFAnnouncementEvent(int scpsLeft, string unitName, int unitNumber, bool allowed = true);

        public int ScpsLeft { get; }
        public string UnitName { get; set; }
        public int UnitNumber { get; set; }
        public bool Allowed { get; set; }
    }
    public class AnnouncementDecontaminationEvent : EventArgs
    {
        public AnnouncementDecontaminationEvent(int announcementId, bool isGlobal, bool allowed = true);

        public int Id { get; set; }
        public bool IsGlobal { get; set; }
        public bool Allowed { get; set; }
    }
    public class LCZDeconEvent : EventArgs
    {
        public LCZDeconEvent(bool allowed = true);

        public bool Allowed { get; set; }
    }
    public class AlphaStartEvent : AlphaStopEvent
    {
        public AlphaStartEvent(Player player, bool allowed = true);
    }
    public class RoleChangeEvent : EventArgs
    {
        public RoleChangeEvent(Player player, RoleType newRole, List<ItemType> items, bool savePos, bool escaped);

        public Player Player { get; }
        public RoleType NewRole { get; set; }
        public List<ItemType> Items { get; }
        public bool Escaped { get; set; }
        public bool SavePos { get; set; }
    }
    public class DeadEvent : EventArgs
    {
        public DeadEvent(Player killer, Player target, PlayerStats.HitInfo hitInfo);

        public Player Killer { get; }
        public Player Target { get; }
        public PlayerStats.HitInfo HitInfo { get; set; }
    }
    public class EscapeEvent : EventArgs
    {
        public EscapeEvent(Player player, RoleType newRole, bool allowed = true);

        public Player Player { get; }
        public RoleType NewRole { get; set; }
        public bool Allowed { get; set; }
    }
    public class LeaveEvent : JoinEvent
    {
        public LeaveEvent(Player player);
    }
    public class JoinEvent : EventArgs
    {
        public JoinEvent(Player player);

        public Player Player { get; }
    }
    public class PickupItemEvent : DropItemEvent
    {
        public PickupItemEvent(Player player, Pickup pickup, bool allowed = true);

        public bool Allowed { get; set; }
    }
    public class DropItemEvent : EventArgs
    {
        public DropItemEvent(Player player, Pickup pickup);

        public Player Player { get; }
        public Pickup Pickup { get; }
    }
    public class DroppingItemEvent : EventArgs
    {
        public DroppingItemEvent(Player player, Inventory.SyncItemInfo item, bool allowed = true);

        public Player Player { get; }
        public Inventory.SyncItemInfo Item { get; set; }
        public bool Allowed { get; set; }
    }
    public class IcomSpeakEvent : EventArgs
    {
        public IcomSpeakEvent(Player player, bool allowed = true);

        public Player Player { get; }
        public bool Allowed { get; set; }
    }
    public class InteractLockerEvent : EventArgs
    {
        public InteractLockerEvent(Player player, Locker locker, LockerChamber lockerChamber, byte lockerId, byte chamberId, bool allowed);

        public Player Player { get; }
        public Locker Locker { get; }
        public LockerChamber Chamber { get; }
        public byte LockerId { get; }
        public byte ChamberId { get; }
        public bool Allowed { get; set; }
    }
    public class InteractLiftEvent : EventArgs
    {
        public InteractLiftEvent(Player player, Lift.Elevator elevator, Lift lift, bool allowed = true);

        public Player Player { get; }
        public Lift.Elevator Elevator { get; }
        public Lift Lift { get; }
        public bool Allowed { get; set; }
    }
    public class InteractGeneratorEvent : EventArgs
    {
        public InteractGeneratorEvent(Player player, Generator generator, GeneratorStatus status, bool allowed = true);

        public Player Player { get; }
        public Generator Generator { get; }
        public GeneratorStatus Status { get; }
        public bool Allowed { get; set; }
    }
    public class InteractDoorEvent : EventArgs
    {
        public InteractDoorEvent(Player player, Door door, bool allowed = true);

        public Player Player { get; }
        public Door Door { get; set; }
        public bool Allowed { get; set; }
    }
    public class InteractEvent : EventArgs
    {
        public InteractEvent(Player player);

        public Player Player { get; }
    }
    public class DiesEvent : EventArgs
    {
        public DiesEvent(Player killer, Player target, PlayerStats.HitInfo hitInfo, bool allowed = true);

        public Player Killer { get; }
        public Player Target { get; }
        public PlayerStats.HitInfo HitInfo { get; set; }
        public bool Allowed { get; set; }
    }
    public class DamageEvent : EventArgs
    {
        public DamageEvent(Player attacker, Player target, PlayerStats.HitInfo hitInformations, bool allowed = true);

        public Player Attacker { get; }
        public Player Target { get; }
        public PlayerStats.HitInfo HitInformations { get; }
        public int Time { get; }
        public DamageTypes.DamageType DamageType { get; }
        public int Tool { get; }
        public float Amount { get; set; }
        public bool Allowed { get; set; }
    }
    public class UnCuffEvent : CuffEvent
    {
        public UnCuffEvent(Player cuffer, Player target, bool allowed = true);
    }
    public class CuffEvent : EventArgs
    {
        public CuffEvent(Player cuffer, Player target, bool allowed = true);

        public Player Cuffer { get; }
        public Player Target { get; }
        public bool Allowed { get; set; }
    }
    public class ReportCheaterEvent : EventArgs
    {
        public ReportCheaterEvent(Player sender, Player target, int port, string reason, bool allowed = true);

        public Player Sender { get; }
        public Player Target { get; }
        public int Port { get; }
        public string Reason { get; set; }
        public bool Allowed { get; set; }
    }
    public class ReportLocalEvent : EventArgs
    {
        public ReportLocalEvent(Player issuer, Player target, string reason, bool allowed = true);

        public Player Issuer { get; }
        public Player Target { get; }
        public string Reason { get; set; }
        public bool Allowed { get; set; }
    }
}