using Serenity;
using System;

namespace SerenityTutorialMovie.Common.Jobs
{
    public class SimpleJob
    {
        // If you want to run SQL with a connection, add this
        // private readonly ISqlConnections Connections;
        // public SimpleJob(ISqlConnections connections) 
        // {
        //     this.Connections = connections ?? throw new ArgumentNullException(nameof(connections));
        // }

        public void Run()
        {
            new Exception("Hello Serenity from Hangfire!").Log();

            // using (var connection = Connections.NewFor<MyRow>())
            // {
            //     do stuff
            // }
        }
    }
}