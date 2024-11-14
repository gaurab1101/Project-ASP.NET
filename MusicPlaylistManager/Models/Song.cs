using System.ComponentModel.DataAnnotations;

namespace MusicPlaylistManager.Models
{
    public class Song
    {
        public int SongId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Artist is required.")]
        public string Artist { get; set; }


        [Required(ErrorMessage = "Duration is required.")]
        public string Duration { get; set; }

        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; } // Navigation property
        
    }
}

