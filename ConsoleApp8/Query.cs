using System.Collections.Generic;
using System.Linq;
using GraphQL;

namespace SimpleGraphQLApplication
{
    public class Query
    {
        private readonly IEnumerable<Student> _students = new List<Student>
        {
            new Student(1,"Fedor", 1),
            new Student(2,"Michel", 2),
            new Student(3,"Filip", 3)
        };

        [GraphQLMetadata("hello")]
        public string GetHello() => "Hello Query class";
        
        [GraphQLMetadata("students")]
        public IEnumerable<Student> GetStudents() => _students;

        [GraphQLMetadata("student")]
        public Student GetStudentById(int id) => _students.SingleOrDefault(x => x.Id == id);
    }
}
