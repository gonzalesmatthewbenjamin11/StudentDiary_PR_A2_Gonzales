using System;

namespace StudentDiary.Infrastructure.Entities
{
    public class DiaryEntry
    {
        public int Id { get; set; }              // Primary Key
        public string Title { get; set; }        // Entry title
        public string Content { get; set; }      // Entry body
        public DateTime CreatedAt { get; set; }  // Timestamp
        public int UserId { get; set; }          // Foreign Key
        public User User { get; set; }           // Navigation property
    }
}
