using MelonLoader;

namespace FC_AP
{
    internal class ToggleSave
    {
        private static MelonPreferences_Category ToggleCategory;

        private static MelonPreferences_Entry<bool> fc_apEnabled;

        private static MelonPreferences_Entry<bool> restartEnabled;

        private static MelonPreferences_Entry<bool> greatRestart;

        private static MelonPreferences_Entry<bool> missRestart;

        private static MelonPreferences_Entry<bool> ghostMiss;

        private static MelonPreferences_Entry<bool> collectableMiss;

        internal static bool FC_APEnabled
        {
            get { return fc_apEnabled.Value; }
            set { fc_apEnabled.Value = value; }
        }

        internal static bool RestartEnabled
        {
            get { return restartEnabled.Value; }
            set { restartEnabled.Value = value; }
        }

        internal static bool GreatRestartEnabled
        {
            get { return greatRestart.Value; }
            set { greatRestart.Value = value; }
        }

        internal static bool MissRestartEnabled
        {
            get { return missRestart.Value; }
            set { missRestart.Value = value; }
        }

        internal static bool GhostMissEnabled
        {
            get { return ghostMiss.Value; }
            set { ghostMiss.Value = value; }
        }

        internal static bool CollectableMissEnabled
        {
            get { return collectableMiss.Value; }
            set { collectableMiss.Value = value; }
        }

        internal static void Load()
        {
            ToggleCategory = MelonPreferences.CreateCategory("FC AP");
            ToggleCategory.SetFilePath("UserData/FC AP.cfg", true);
            fc_apEnabled = ToggleCategory.CreateEntry("FC/AP Enabled", false, null, "Whether the FC AP indicator is enabled.");
            restartEnabled = ToggleCategory.CreateEntry("Restart Enabled", false, null, "Whether the auto restart is enabled.");
            greatRestart = ToggleCategory.CreateEntry("Hit Great Restart", true, null, "Whether auto restart when you hit a great");
            missRestart = ToggleCategory.CreateEntry("Miss Restart", true, null, "Whether auto restart when you get a miss");
            ghostMiss = ToggleCategory.CreateEntry("Ghost Miss", true, null, "Whether delete FC indicator when missing a ghost");
            collectableMiss = ToggleCategory.CreateEntry("Collectable note Miss", true, null, "Whether delete FC indicator when missing a collectable notes");
        }
    }
}