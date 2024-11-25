namespace KretaProject.Models
{
    
    public class Player
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public int Wins { get; set; }
        public int Matches { get; set; }

        public Player(string name, string email, DateTime createDate, int wins, int matches)
        {
            Name = name;
            Email = email;
            CreationDate = createDate;
            Wins = wins;
            Matches = matches;
        }

        public Player()
        {
            Name = string.Empty;
            Email = string.Empty;
            CreationDate = new DateTime();
            Wins = 0;
            Matches = 0;
        }
    }
}
