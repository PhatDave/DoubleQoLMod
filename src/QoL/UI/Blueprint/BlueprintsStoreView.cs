﻿using DoubleQoL.Game.Blueprints;
using Mafi;
using Mafi.Core.Buildings.Offices;
using Mafi.Core.Prototypes;
using Mafi.Unity;
using Mafi.Unity.InputControl;

namespace DoubleQoL.QoL.UI.Blueprint
{

    internal class BlueprintsStoreView : BlueprintsView {
        public override bool isLocal => false;

        public BlueprintsStoreView(IUnityInputMgr inputMgr, LazyResolve<BlueprintsController> controller, NewInstanceOf<QoLBlueprintsLibrary> blueprintsLibrary, UnlockedProtosDbForUi unlockedProtosDb, ProtosDb protosDb, BlueprintCreationController blueprintCreationController, CaptainOfficeManager captainOfficeManager) : base(inputMgr, controller, blueprintsLibrary, unlockedProtosDb, protosDb, blueprintCreationController, captainOfficeManager) {
        }
    }
}