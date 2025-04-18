using StardewModdingAPI;            // Provides the core SMAPI API types
using StardewModdingAPI.Events;     // Provides event types for SMAPI
using StardewValley;                // Provides the main game classes

namespace SimpleStardewMod
{
    /// The main entry point for the mod. Inherits from SMAPI's Mod class.
    internal sealed class ModEntry : Mod
    {
        // Tracks whether the speed boost is currently active
        private bool speedBoostActive = false;

        // The player's normal walking/running speed
        private readonly int normalSpeed = 5;

        // The player's boosted speed when the boost is active
        private readonly int boostedSpeed = 10;

     
        /// Called once when the mod is first loaded.
        /// Subscribe to the events needed.
        public override void Entry(IModHelper helper)
        {
            // Listen for any button presses
            helper.Events.Input.ButtonPressed += OnButtonPressed;

            // Listen for each game tick before movement is processed
            helper.Events.GameLoop.UpdateTicking += OnUpdateTicking;
        }
        
        /// Handles button presses. Toggles the speed boost on/off when K is pressed.
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            // Only run this code if the game world is fully loaded
            if (!Context.IsWorldReady)
                return;

            // Check if the pressed key is K
            if (e.Button == SButton.K)
            {
                // Flip the boost state
                speedBoostActive = !speedBoostActive;

                // Log the new state to the SMAPI console
                Monitor.Log(
                    speedBoostActive
                        ? $"Speed boost ON (speed = {boostedSpeed})"
                        : $"Speed boost OFF (speed = {normalSpeed})",
                    LogLevel.Info
                );
            }
        }
        
        /// Called every game tick before player movement is applied.
        /// Sets the player's speed based on whether the boost is active.
        private void OnUpdateTicking(object? sender, UpdateTickingEventArgs e)
        {
            // Only run if the player can move freely (not in dialogue or cutscene)
            if (!Context.IsPlayerFree)
                return;

            // Apply either the boosted or normal speed
            Game1.player.speed = speedBoostActive ? boostedSpeed : normalSpeed;
        }
    }
}