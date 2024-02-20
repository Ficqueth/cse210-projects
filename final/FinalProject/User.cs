public class User {
    public string Username { get; set; }
    private string Password { get; set; }
    public string Email { get; set; }

    public User(string username, string password, string email) {
        Username = username;
        Password = password;
        Email = email;
    }

    public bool Authenticate(string username, string password) {
        return Username == username && Password == password;
    }
}
