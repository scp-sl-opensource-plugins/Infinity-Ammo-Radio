namespace InfinityAmmo_Radio.InfinityRadio
{
    internal class PlayerHandlers
    {
        internal static void Subscribe()
        {
            Exiled.Events.Handlers.Player.UsingRadioBattery += OnUsingRadioBattery;
            Exiled.Events.Handlers.Item.UsingRadioPickupBattery += OnUsingRadioPickupBattery;
        }

        internal static void Unsubscribe()
        {
            Exiled.Events.Handlers.Player.UsingRadioBattery -= OnUsingRadioBattery;
            Exiled.Events.Handlers.Item.UsingRadioPickupBattery -= OnUsingRadioPickupBattery;
        }

        private static void OnUsingRadioBattery(Exiled.Events.EventArgs.Player.UsingRadioBatteryEventArgs ev) => ev.IsAllowed = false;
        private static void OnUsingRadioPickupBattery(Exiled.Events.EventArgs.Item.UsingRadioPickupBatteryEventArgs ev) => ev.IsAllowed = false;
    }
}