namespace DesignPrinciples.DIP
{
    internal class DIPDemo
    {
        public void DIPDemoMethod()
        {
            var players = new Dictionary<string, IAudioPlayer>
            {
                {"MP3",new MP3Player() },
                {"WAV",new WAVPlayer() },
            };

            var musicPlayer = new MusicPlayer(players);
            musicPlayer.Play("song1.mp3", "MP3");
            musicPlayer.Play("song2.wav", "WAV");
            musicPlayer.Play("song3.mp4", "MP4");
        }
    }
}