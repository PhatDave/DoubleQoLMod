﻿using DoubleQoL.Game.Patcher;
using DoubleQoL.Game.Prototypes;
using Mafi;
using Mafi.Collections;
using Mafi.Core.Game;
using Mafi.Core.Mods;
using Mafi.Core.Prototypes;
using System;

namespace DoubleQoL {

    public sealed class DoubleQoL : IMod {
        public static Version ModVersion = new Version(1, 5, 2);
        public string Name => "DoubleQoL";
        public int Version => 1;
        public bool IsUiOnly => false;

        public Option<IConfig> ModConfig { get; }

        public void Initialize(DependencyResolver resolver, bool gameWasLoaded) {
            Logging.Log.Info($"Current {Name} version v{ModVersion.ToString(3)}");
            InitializePatchers(resolver);
        }

        public void ChangeConfigs(Lyst<IConfig> configs) {
        }

        public void RegisterPrototypes(ProtoRegistrator registrator) {
            PrototypeHelper.Instance.Init(registrator);
        }

        public void RegisterDependencies(DependencyResolverBuilder depBuilder, ProtosDb protosDb, bool wasLoaded) {
        }

        private void InitializePatchers(DependencyResolver resolver) {
            MineTowerPatcher.Instance?.Init(resolver);
            VehiclePatcher.Instance?.Init(resolver);
            DaveVehiclePatcher.Instance?.Init(resolver);
        }

        public void EarlyInit(DependencyResolver resolver) {
        }
    }
}
