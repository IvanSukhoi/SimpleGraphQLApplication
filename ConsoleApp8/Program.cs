using System;
using GraphQL;
using GraphQL.Types;
using SimpleGraphQLApplication;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.For(GraphqlSchemes.Query, _ =>
            {
                _.Types.Include<Query>();
            });

            var simpleQuery = schema.Execute(_ => { _.Query = "{ hello }"; });
            var withoutParameterQuery = schema.Execute(_ => { _.Query = "{ students { name, course } }"; });
            var withParameterQuery = schema.Execute(_ => { _.Query = " { student(id: 1) { name, course } }"; });

            Console.WriteLine(
                $"SimpleQuery: {simpleQuery}\n\n WithoutParameterQuery: {withoutParameterQuery}\n\n WithParameterQuery: {withParameterQuery}");
        }
    }
}
