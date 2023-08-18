using Domain.Models;

namespace ServiceLayer.AttendanceService
{
    public interface IAttendanceService
    {

        IEnumerable<Attendance> GetAttendances();
        Attendance GetAttendance(long id);
        void InsertAttendance(Attendance attendance);
        void UpdateAttendance(Attendance attendance);
        void DeleteAttendance(long id);

    }
}
