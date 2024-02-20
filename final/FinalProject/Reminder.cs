
public class Reminder {
    private Task _task;
    private DateTime _reminderDateTime;
    private bool _isDismissed;

    public Reminder(Task task, DateTime reminderDateTime) {
        _task = task;
        _reminderDateTime = reminderDateTime;
        _isDismissed = false;
    }

    public void DismissReminder() {
        _isDismissed = true;
    }
}
