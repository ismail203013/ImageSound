public class MusicLibrary
{
    static void GetMusicTracks()
    {
        public List<MusicTrack> GetMusicTracks(string genre)
        {
            return tracks.Where(track => string.Equals(track.Genre, genre, && track.Duration > 0).ToList());
        }
    }
}

class Program
{
    MusicLibrary musicLibrary = new MusicLibrary();

    List<MusicTrack> rockTracks = musicLibrary.GetMusicTracks("Rock");

     foreach (var track in rockTracks)
        {
            return track.Title;
        }
}

