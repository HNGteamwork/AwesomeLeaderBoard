using System;

namespace AwesomeLeaderBoard.Models
{
    public class LeaderboardModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        // [JsonPropertyName("")]
        public string Username { get; set; }
        public string Email { get; set; }
        public int TotalPoint { get; set; }
    }
}