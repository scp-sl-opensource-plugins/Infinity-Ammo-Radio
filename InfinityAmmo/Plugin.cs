using Exiled.API.Features;

namespace InfinityAmmo_Radio
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin plugin;
        public override string Prefix => "InfinityAmmo&Radio";
        public override string Name => "InfinityAmmo&Radio";
        public override string Author => "[OPENSOURCE PLUGIN] [https://github.com/scp-sl-opensource-plugins]";
        public override void OnEnabled()
        {
            plugin = this;
            base.OnEnabled();

            if (Config.InfinityRadioIsEnabled)
            {
                InfinityAmmo.PlayerHandlers.Subsribe();
                InfinityAmmo.MapHandlers.Subscribe();
                Log.Debug("Infinity ammo is enabled!");
            }

            if (Config.InfinityRadioIsEnabled)
            {
                InfinityRadio.PlayerHandlers.Subscribe();
                Log.Debug("Infinity radio is enabled!");
            }
        }

        public override void OnDisabled()
        {
            plugin = null;
            base.OnDisabled();

            if (Config.InfinityRadioIsEnabled)
            {
                InfinityAmmo.PlayerHandlers.Unsubsribe();
                InfinityAmmo.MapHandlers.Unsubscribe();
                Log.Debug("Infinity ammo is disabled!");
            }

            if (Config.InfinityRadioIsEnabled)
            {
                InfinityRadio.PlayerHandlers.Unsubscribe();
                Log.Debug("Infinity radio is disabled!");
            }
        }
    }
}