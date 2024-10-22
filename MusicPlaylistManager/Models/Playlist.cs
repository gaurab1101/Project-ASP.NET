using System.ComponentModel.DataAnnotations;

namespace MusicPlaylistManager.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }

        [Required(ErrorMessage = "Playlist name is required.")]
        public string Name { get; set; }

        public string Genre { get; set; }
        public string Description { get; set; }

        public List<Song> Songs { get; set; } = new List<Song>(); // Initialize list
    }
}
