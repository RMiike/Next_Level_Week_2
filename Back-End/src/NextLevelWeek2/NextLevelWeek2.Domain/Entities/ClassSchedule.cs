namespace Proffy.Core.Entities
{
    public class ClassSchedule
    {
        protected ClassSchedule()        {                    }
        private ClassSchedule(int id, int weekDay, int from, int to, int classId)
        {
            Id = id;
            WeekDay = weekDay;
            From = from;
            To = to;
            ClassId = classId;
        }

        public static ClassSchedule Create(int id, int weekDay, int from, int to, int classId)
        {
            return new ClassSchedule(id,weekDay,from,to,classId);
        }

        public int Id { get; private set; }
        public int WeekDay { get; private set; }
        public int From { get; private set; }
        public int To { get; private set; }
        public int ClassId { get; private set; }
        public Class Class { get; private set; }
    }
}
