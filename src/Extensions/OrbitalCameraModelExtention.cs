﻿using Mafi;
using Mafi.Unity;
using Mafi.Unity.Camera;
using System;
using System.Reflection;

namespace DoubleQoL.Extensions {

    public static class OrbitalCameraModelExtention {

        private static Type GetOrbitalCameraModelType() {
            var type = typeof(UnityMod).Assembly.GetType("Mafi.Unity.Camera.OrbitalCameraModel");
            return type is null ? throw new Exception("Couldn't find the OrbitalCameraModel type.") : type;
        }

        public static void SetValues(this OrbitalCameraModel orbitalCameraModel) {
            var type = GetOrbitalCameraModelType();
            type.GetField("m_maxPivotDistance", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(orbitalCameraModel, new RelTile1f(6000));
            type.GetField("m_minHeightAboveTerrain", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(orbitalCameraModel, new RelTile1f(-100));
        }
    }
}