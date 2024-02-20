using System;

public class Reminder {
    public Task _task { get; private set; }
    public DateTime _reminderDateTime { get; set; }
    public bool _isDismissed { get; set; }

    public Reminder(Task task, DateTime reminderDateTime) {
        _task = task;
        _reminderDateTime = reminderDateTime;
        _isDismissed = false;
    }

    public void DismissReminder() {
        _isDismissed = true;
    }
}
