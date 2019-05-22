using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromHybridTests.Controllers
{
    public class Cmd1
    {
        public readonly int Id;

        public Cmd1(int id)
        {
            Id = id;
        }
    }

    public class Cmd2
    {
        public int Id { get; }

        public Cmd2(int id)
        {
            Id = id;
        }
    }

    public class Cmd3
    {
        public int Id { get; internal set; }

        public Cmd3(int id)
        {
            Id = id;
        }
    }

    public class Cmd4
    {
        public int Id { get; set; }
    }

    public class Cmd5
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }

        public Cmd5(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Cmd6
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
    }
}
