﻿using DoubleQoL.Game.Patcher;
using DoubleQoL.Game.Prototypes;
using Mafi;
using Mafi.Collections;
using Mafi.Core.Game;
using Mafi.Core.Mods;
using Mafi.Core.Prototypes;
using System;

namespace DoubleQoL
{
    public sealed class DoubleQoL : IMod
    {
        public string Name => "DoubleQoL";
        public int Version => 1;
        public bool IsUiOnly => false;

        public void Initialize(DependencyResolver resolver, bool gameWasLoaded)
        {
            var version = GetVersion();

            Logging.Log.Info($"Current {Name} mod version v{version.Major}.{version.Minor}.{version.Build}");
        }

        private static Version GetVersion() => new Version(1, 0, 0);

        public void ChangeConfigs(Lyst<IConfig> configs)
        { }

        public void RegisterPrototypes(ProtoRegistrator registrator)
        {
            PrototypeHelper.Instance.init(registrator);
        }

        public void RegisterDependencies(DependencyResolverBuilder depBuilder, ProtosDb protosDb, bool wasLoaded)
        {
            MineTowerPatcher.Instance.Init(protosDb);
            VehiclePatcher.Instance.Init();
        }
    }
}