using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestMethod]
public void GetMusicTracks_ReturnsTracksWithMatchingGenre()
{
   
    MusicLibrary musicLibrary = new MusicLibrary();
    musicLibrary.AddTrack(new MusicTrack("Song 1", "Artist 1", "Rock", 180));
    musicLibrary.AddTrack(new MusicTrack("Song 2", "Artist 2", "Pop", 240));
    musicLibrary.AddTrack(new MusicTrack("Song 3", "Artist 3", "Rock", 300));

    
    List<MusicTrack> rockTracks = musicLibrary.GetMusicTracks("Rock");
    List<MusicTrack> popTracks = musicLibrary.GetMusicTracks("Pop");

    
    foreach (var track in rockTracks)
    {
        Assert.AreEqual("Rock", track.Genre);
    }

    foreach (var track in popTracks)
    {
        Assert.AreEqual("Pop", track.Genre);
    }
}

[TestMethod]
public void GetMusicTracks_ReturnsNoTracksWithZeroDuration()
{
   
    MusicLibrary musicLibrary = new MusicLibrary();
    musicLibrary.AddTrack(new MusicTrack("Song 1", "Artist 1", "Rock", 180));
    musicLibrary.AddTrack(new MusicTrack("Song 2", "Artist 2", "Pop", 0));
    musicLibrary.AddTrack(new MusicTrack("Song 3", "Artist 3", "Rock", 300));

    
    List<MusicTrack> rockTracks = musicLibrary.GetMusicTracks("Rock");
    List<MusicTrack> popTracks = musicLibrary.GetMusicTracks("Pop");

   
    foreach (var track in rockTracks)
    {
        Assert.IsTrue(track.Duration > 0);
    }

    foreach (var track in popTracks)
    {
        Assert.IsTrue(track.Duration > 0);
    }
}
