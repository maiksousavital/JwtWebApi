namespace JwtWebApi.Model
{
    public class RefreshToken
    {
        //Note: For more comprehensive implementation, add an ID and store all refresh token of a particular user in the DB

        public string Token { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expires { get; set; }
    }
}
