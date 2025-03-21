namespace ShasthoBondhu.Data.Entities.Enums;


/// <summary>
/// Represents the possible states of an appointment in the system.
/// </summary>

public enum AppointmentStatus
{
    Scheduled = 0,

    Confirmed = 1,

    Completed = 2,

    Cancelled = 4,

    Rescheduled = 8,

    NoShow = 16,

    FollowUpRequired = 32
}