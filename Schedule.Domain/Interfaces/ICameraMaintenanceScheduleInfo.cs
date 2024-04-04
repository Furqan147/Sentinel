namespace Schedule.Domain.Interfaces
{
    public interface ICameraMaintenanceScheduleInfo
    {
        public int MaintenanceScheduleId { get; set; }
        public string CronExpression { get; set; }
        int CameraId { get; }
    }
}
