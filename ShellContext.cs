using MongoDB.Driver;

namespace MongoAdmin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class ShellContext
    {

        MongoServer _server;

        public static string [] Globals = new []{
            "db", "show", "use"
        };

        public static string[] CollectionFunctions = new[] {
            "find", "insert", "update", "save", "distinct", "remove"
        }.OrderBy(x => x).ToArray();

        public static string[] ShowArgs = new[]{
            "dbs", "collections", "users", "profile"
        };

    }
}
