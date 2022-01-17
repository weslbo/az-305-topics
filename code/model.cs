using System.Collections.Generic;

namespace code
{
    public class Question
    {
        public string question { get; set; }
        public string whiteboard { get; set; }
        public List<string> extra { get; set; }
        public List<string> links { get; set; }
        public string link { get; set; }
    }


    public class Unit
    {
        public string unit { get; set; }
        public string link { get; set; }
        public List<Question> questions { get; set; }

        public string whiteboard { get; set; }
    }

    public class Module
    {
        public string module { get; set; }
        public string link { get; set; }
        public List<Unit> units { get; set; }

        public string whiteboard { get; set; }

    }

    public class Root
    {
        public List<Module> modules { get; set; }
    }
}