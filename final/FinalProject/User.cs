public class User {
    public string _username { get; set; }
    private string _password { get; set; }
    public string _email { get; set; }

    public User(string username, string password, string email) {
        _username = username;
        _password = password;
        _email = email;
    }

    public bool Authenticate(string username, string password) {
        return _username == username && _password == password;
    }
}
