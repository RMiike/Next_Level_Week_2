namespace Proffy.Core.Entities
{
    public class ClassSchedule
    {
        public int Id { get; private set; }
        public int WeekDay { get; private set; }
        public int From { get; private set; }
        public int To { get; private set; }
        public int ClassId { get; private set; }
    }
}
