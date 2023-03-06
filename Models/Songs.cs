using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace SongLister.Models  
{  
    public class Songs
    {  
        public int Id {get; set;}  
        [Required]  
        public string Title {get; set;}  
        [Required]  
        public string Artist {get; set;}  
        [Required]  
        public string Album {get; set;}  
        [Required]  
        public string Genre {get; set;}  
    }  
}