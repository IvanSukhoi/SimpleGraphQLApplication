namespace SimpleGraphQLApplication
{
    public static class GraphqlSchemes
    {
        public static string Query = @"
                type Student {
                    id: ID
                    name: String,
                    course: Int
                }
                type Query {
                    hello: String,
                    students: [Student],
                    student(id: ID): Student
                }
                ";
    }
}
