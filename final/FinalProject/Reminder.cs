using System;

public class Reminder {
    public Task Task { get; private set; }
    public DateTime ReminderDateTime { get; set; }
    public bool IsDismissed { get; set; }

    public Reminder(Task task, DateTime reminderDateTime) {
        Task = task;
        ReminderDateTime = reminderDateTime;
        IsDismissed = false;
    }

    public void DismissReminder() {
        IsDismissed = true;
    }
}
