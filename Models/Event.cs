using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Event
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Event date is required")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required")]
        public int Attendees { get; set; } = 0;
    }
}