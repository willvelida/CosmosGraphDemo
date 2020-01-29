using ExRam.Gremlinq.Core;
using Gremlin.Net.Structure;
using System;

namespace CosmosGraphDemo.Core
{
    public class Program
    {
        private readonly IGremlinQuerySource _gremlinQuerySource;

        public Program(IGremlinQuerySource gremlinQuerySource)
        {
            _gremlinQuerySource = gremlinQuerySource.ConfigureEnvironment(env => env
                .UseModel(GraphModel.FromBaseTypes<Vertex, Edge>(lookup => lookup
                .IncludeAssembliesOfBaseTypes())))
                .UseCosmosDb(new Uri(""), "", "", "");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
