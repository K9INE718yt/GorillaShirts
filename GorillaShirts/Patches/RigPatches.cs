﻿using GorillaShirts.Behaviors.Tools;
using HarmonyLib;
using Photon.Realtime;

namespace GorillaShirts.Patches
{
    [HarmonyPatch]
    public class RigPatches
    {
        private static Events _Events;

        public static void Prepare() => _Events = new Events();

        public static void AddPatch(Player player, VRRig vrrig) => _Events.TriggerRigAdded(player, vrrig);

        public static void RemovePatch(Player player, VRRig vrrig) => _Events.TriggerRigRemoved(player, vrrig);
    }
}
