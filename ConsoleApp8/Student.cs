namespace SimpleGraphQLApplication
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }
        public int Course { get; }

        public Student(int id, string name, int course)
        {
            Name = name;
            Course = course;
            Id = id;
        }
    }
}
