namespace BlazorDeepDive.Models
{
    public class ServerDetails
    {
        public ServerDetails()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1);
            isOnline = randomNumber == 0 ? false : true;
        }


        public int Id { get; set; }
        public bool isOnline { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
    }
}
