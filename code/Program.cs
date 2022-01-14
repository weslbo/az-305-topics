using System;
using System.IO;
using System.Text;
using YamlDotNet.Serialization.NamingConventions;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            var deserializer = new YamlDotNet.Serialization.DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var root = deserializer.Deserialize<Root>(File.ReadAllText("../topics.yaml"));

            var sb = new StringBuilder();
            var i = 1;

            sb.AppendLine("# AZ-305 Discussion Topics\n");
            sb.AppendLine("## Table of contents\n");

            root.modules.ForEach(m => sb.AppendLine($"- [{m.module}](#{m.module.ToLower().Replace(" ", "-")}-learn-module)"));
            sb.AppendLine();

            foreach (var module in root.modules)
            {
                sb.AppendLine($"# {module.module} ([Learn module]({module.link}))\n");

                if (!string.IsNullOrEmpty(module.whiteboard))
                    sb.AppendLine($"![whiteboard]({module.whiteboard})\n");

                foreach (var unit in module.units)
                {
                    sb.AppendLine($"## {unit.unit} ([Unit]({unit.link}))\n");

                    if (!string.IsNullOrEmpty(unit.whiteboard))
                        sb.AppendLine($"![whiteboard]({unit.whiteboard})\n");

                    if (unit.questions == null)
                        break;

                    foreach (var q in unit.questions)
                    {
                        sb.Append($"{i++}. {q.question}");

                        if (q.links != null)
                            q.links.ForEach(link => sb.Append($" [[doc]]({link})"));

                        sb.Append("\n");
                    }

                    sb.AppendLine();
                }
            }

            File.WriteAllText($"../README.md", sb.ToString());

            Console.WriteLine("Finished");
        }
    }
}
