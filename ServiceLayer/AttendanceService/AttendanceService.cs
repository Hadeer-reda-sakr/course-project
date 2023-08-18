using Domain.Models;
using presentence.Repository;

namespace ServiceLayer.AttendanceService
{
    public class AttendanceService : IAttendanceService
    {
        private IRepository<Attendance> attendanceRepository;
        public AttendanceService(IRepository<Attendance> attendanceRepository)
        {
            this.attendanceRepository = attendanceRepository;

        }
        public IEnumerable<Attendance> GetAttendances()
        {
            return attendanceRepository.GetAll();
        }

        public Attendance GetAttendance(long id)
        {
            return attendanceRepository.Get(id);
        }

        public void InsertAttendance(Attendance attendance)
        {
            attendanceRepository.Insert(attendance);
        }
        public void UpdateAttendance(Attendance attendance)
        {
            attendanceRepository.Update(attendance);
        }

        public void DeleteAttendance(long id)
        {
            Attendance attendance = GetAttendance(id);
            attendanceRepository.Remove(attendance);
            attendanceRepository.Save();
        }
    }
}
