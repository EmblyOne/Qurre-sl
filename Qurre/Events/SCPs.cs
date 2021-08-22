﻿
using Qurre.Events.modules;
namespace Qurre.Events
{
    public static class Scp049
    {
        public static event Main.AllEvents<StartRecallEvent> StartRecall;
        public static event Main.AllEvents<FinishRecallEvent> FinishRecall;
    }
    public static class Scp079
    {
        public static event Main.AllEvents<GeneratorActivateEvent> GeneratorActivate;
        public static event Main.AllEvents<GetEXPEvent> GetEXP;
        public static event Main.AllEvents<GetLVLEvent> GetLVL;
    }
    public static class Scp096
    {
        public static event Main.AllEvents<EnrageEvent> Enrage;
        public static event Main.AllEvents<WindupEvent> Windup;
        public static event Main.AllEvents<CalmDownEvent> CalmDown;
        public static event Main.AllEvents<AddTargetEvent> AddTarget;
    }
    public static class Scp106
    {
        public static event Main.AllEvents<PortalUsingEvent> PortalUsing;
        public static event Main.AllEvents<PortalCreateEvent> PortalCreate;
        public static event Main.AllEvents<ContainEvent> Contain;
        public static event Main.AllEvents<FemurBreakerEnterEvent> FemurBreakerEnter;
        public static event Main.AllEvents<PocketDimensionEnterEvent> PocketDimensionEnter;
        public static event Main.AllEvents<PocketDimensionEscapeEvent> PocketDimensionEscape;
        public static event Main.AllEvents<PocketDimensionFailEscapeEvent> PocketDimensionFailEscape;
    }
    public static class Scp173
    {
        public static event Main.AllEvents<BlinkEvent> Blink;
    }
    public static class Scp914
    {
        public static event Main.AllEvents<ActivatingEvent> Activating;
        public static event Main.AllEvents<UpgradeEvent> Upgrade;
        public static event Main.AllEvents<UpgradePlayerEvent> UpgradePlayer;
    }
}