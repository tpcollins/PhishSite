using Phish_Website.Backend.Database.Songs;
using Phish_Website.Backend.Interfaces.SongInterfaces;

namespace Phish_Website.Backend.Model
{
    public class Songs : Shows
    {
        public int SongID{get;set;}
        public string Duration{get;set;}
        public string Name{get;set;}

        public ICreateSong SongCreateBehavior{get;set;}
        public IReadSong SongReadBehavior{get;set;}

        public Songs(){
            SongCreateBehavior = new CreateSong();
            SongReadBehavior = new ReadSong();
        }
    }
}