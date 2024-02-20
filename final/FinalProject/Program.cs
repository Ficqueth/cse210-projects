class Program {
    static void Main(string[] args) {
        // Sample usage of the classes
        TaskList taskList = new TaskList();
        User user = new User("username", "password", "email@example.com");
        UI ui = new UI(taskList);
        ui.Run();
    }
}
