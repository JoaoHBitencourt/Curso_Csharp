namespace StudentsForCourse.Entities
{
    internal class Students
    {
        public int Code { get; set; }

        public Students(int code)
        {
            Code = code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Students))
            {
                return false;
            }
            Students other = obj as Students;
            return Code.Equals(other.Code);
        }
    }
}
