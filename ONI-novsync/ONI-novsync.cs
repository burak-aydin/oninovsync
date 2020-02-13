using System;

using Harmony;

using UnityEngine;

using Internal = UnityEngine.Internal;

namespace ONInovsync
{

    [HarmonyPatch(typeof(DistributionPlatform), "Initialize", new Type[0])]
    internal static class HarmonyPatchDistributionPlatform
    {
        private static bool Prefix()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 1000;
            Screen.fullScreenMode = (Screen.fullScreen) ? FullScreenMode.ExclusiveFullScreen : FullScreenMode.Windowed;
            return true;
        }
    }


}
