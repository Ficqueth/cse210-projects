class Program {
    static void Main(string[] args) {
        TaskList taskList = new TaskList();
        User user = new User("username", "password", "email@example.com"); // Trying to implement an email notification( not done)
        UI ui = new UI(taskList);
        ui.Run();
    }
}
