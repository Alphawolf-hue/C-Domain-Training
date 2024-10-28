namespace DesignPrinciples.DIP
{
    public interface IAudioPlayer
    {
        void Play(string file);
    }

    public class MP3Player : IAudioPlayer
    {
        public void Play(string file)
        {
            Console.WriteLine("MP3 is playing");
        }
    }

    public class WAVPlayer : IAudioPlayer
    {
        public void Play(string file)
        {
            Console.WriteLine("WAV is playing");
        }
    }

    public class MusicPlayer
    {
        private readonly Dictionary<string, IAudioPlayer> _players;
        public MusicPlayer(Dictionary<string, IAudioPlayer> players)
        {
            _players = players;
        }

        public void Play(string file, string format)
        {
            if (_players.ContainsKey(format))
            {
                _players[format].Play(file);
            }
            else
            {
                Console.WriteLine("Unsupported File Format");
            }
        }
    }
}