namespace CyberSecurityChatBotS
{

    using System.Media;

    static void PlayVoiceGreeting()
    {
        SoundPlayer player = new SoundPlayer("welcome.wav");
        player.PlaySync();  // Plays the file before continuing
    }
}