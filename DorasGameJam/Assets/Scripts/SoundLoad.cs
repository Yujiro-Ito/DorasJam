public static class SoundLoad
{
    public static void LoadAllSounds(SoundPlayer player)
    {
        player.LoadBGM("Game", "Game");

        player.LoadVoice("Before", "Before");
        player.LoadVoice("Go", "Go");
        player.LoadVoice("attack1", "attack1");
        player.LoadVoice("attack2", "attack2");
        player.LoadVoice("attack3", "attack3");
        player.LoadVoice("attack4", "attack4");
        player.LoadVoice("attack5", "attack5");
        player.LoadVoice("damage1", "damage1");
        player.LoadVoice("damage2", "damage2");
        player.LoadVoice("damage3", "damage3");
        player.LoadVoice("win1", "win1");
        player.LoadVoice("win2", "win2");
        player.LoadVoice("win3", "win3");

        player.LoadSE("sword1", "sword1");
        player.LoadSE("sword2", "sword2");
        player.LoadSE("sword3", "sword3");
        player.LoadSE("sword4", "sword4");
        player.LoadSE("sword5", "sword5");
        player.LoadSE("sword6", "sword6");
        player.LoadSE("sword7", "sword7");
        player.LoadSE("sword8", "sword8");
        player.LoadSE("sword9", "sword9");
        player.LoadSE("sword10", "sword10");
        player.LoadSE("deadPlayer", "deadPlayer");
    }
}
