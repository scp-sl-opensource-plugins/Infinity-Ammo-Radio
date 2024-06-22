using Exiled.API.Extensions;

namespace InfinityAmmo_Radio.InfinityAmmo
{
    internal class MapHandlers
    {
        internal static void Subscribe()
        {
            Exiled.Events.Handlers.Map.SpawningItem += OnSpawningItem;
            Exiled.Events.Handlers.Map.PickupAdded += OnAddedPickup;
        }
        internal static void Unsubscribe()
        {
            Exiled.Events.Handlers.Map.SpawningItem -= OnSpawningItem;
            Exiled.Events.Handlers.Map.PickupAdded -= OnAddedPickup;
        }

        private static void OnSpawningItem(Exiled.Events.EventArgs.Map.SpawningItemEventArgs ev)
        {
            if (ev.Pickup != null && ev.Pickup.Type.IsAmmo()) ev.IsAllowed = false;
        }

        private static void OnAddedPickup(Exiled.Events.EventArgs.Map.PickupAddedEventArgs ev)
        {
            if (ev.Pickup != null && ev.Pickup.Type.IsAmmo()) ev.Pickup.Destroy();
        }
    }
}