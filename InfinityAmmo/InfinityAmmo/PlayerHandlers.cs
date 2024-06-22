using Exiled.API.Extensions;

namespace InfinityAmmo_Radio.InfinityAmmo
{
    internal class PlayerHandlers
    {
        internal static void Subsribe()
        {
            Exiled.Events.Handlers.Player.ReloadingWeapon += OnReloading;
            Exiled.Events.Handlers.Player.DroppingAmmo += OnDroppingAmmo;
        }
        internal static void Unsubsribe()
        {
            Exiled.Events.Handlers.Player.ReloadingWeapon -= OnReloading;
            Exiled.Events.Handlers.Player.DroppingAmmo -= OnDroppingAmmo;
        }

        private static void OnReloading(Exiled.Events.EventArgs.Player.ReloadingWeaponEventArgs ev)
        {
            if (ev.Player is null || ev.Firearm is null || ev.Firearm.Type == ItemType.ParticleDisruptor) return;
            ev.Player.AddAmmo(ev.Firearm.AmmoType, (ushort)(ev.Firearm.MaxAmmo - ev.Firearm.Ammo));
        }

        private static void OnDroppingAmmo(Exiled.Events.EventArgs.Player.DroppingAmmoEventArgs ev) => ev.IsAllowed = false;
    }
}