using DoubleQoL.Config;
using DoubleQoL.Extensions;
using Mafi.Core.Entities.Dynamic;
using System;
using DoubleQoL.QoL.Tools;
using HarmonyLib;
using Mafi.Unity.InputControl.Inspectors.Vehicles;

namespace DoubleQoL.Game.Patcher {
    internal class DaveVehiclePatcher : APatcher<DaveVehiclePatcher> {
        public override bool DefaultState => true;
        public override bool Enabled => ConfigManager.Instance.QoLs_vehicle.Value;

        public DaveVehiclePatcher() : base("VehicleReplaceView") {
            AddMethod<VehicleReplaceView>("onVehicleSelected", this.GetHarmonyMethod("MyPrefix"),
                this.GetHarmonyMethod("Nothing"));
        }

        private static void MyPrefix(VehicleReplaceView __instance, ref DrivingEntityProto proto) {
            DrivingEntityProto from = Traverse.Create(__instance).Field("m_currentProto")
                .GetValue<DrivingEntityProto>();
            DrivingEntityProto to = proto;
            VehicleTool.UpgradeMap.Add(from, to);
        }

        private static void Nothing() {
        }
    }
}
