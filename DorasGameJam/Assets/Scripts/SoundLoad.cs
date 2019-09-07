public static class SoundLoad
{
    public static void LoadAllSounds(SoundPlayer player)
    {
        player.LoadBGM("Game", "Game");

        player.LoadSE("Clear", "clear");
        player.LoadSE("Bound", "bound");
    }
}
