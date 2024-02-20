public class User {
    private string _username;
    private string _password;
    private string _email;

    public User(string username, string password, string email) {
        _username = username;
        _password = password;
        _email = email;
    }

    public bool Authenticate(string username, string password) {
        return _username == username && _password == password;
    }
}
