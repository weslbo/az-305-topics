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

            root.modules.ForEach(m => m.units.ForEach(u => i += (u.questions == null ? 0 : u.questions.Count)));
            sb.AppendLine($"__Total number of questions:__ {i}\n");

            root.modules.ForEach(m => sb.AppendLine($"- [{m.module}](#{m.module.ToLower().Replace(" ", "-")}-learn-module)"));
            sb.AppendLine();

            foreach (var module in root.modules)
            {
                sb.AppendLine($"# {module.module} ([Learn module]({module.link}))\n");

                if (!string.IsNullOrEmpty(module.whiteboard))
                    sb.AppendLine($"![whiteboard]({module.whiteboard})\n");

                foreach (var unit in module.units)
                {
                    var j = 1;

                    sb.AppendLine($"## {unit.unit} ([Unit]({unit.link}))\n");

                    if (!string.IsNullOrEmpty(unit.whiteboard))
                        sb.AppendLine($"![whiteboard]({unit.whiteboard})\n");

                    if (unit.questions == null)
                        break;

                    foreach (var q in unit.questions)
                    {
                        sb.Append($"{j++}. {q.question}");

                        if (q.links != null)
                            q.links.ForEach(link => sb.Append($" [[doc]]({link})"));

                        if (!string.IsNullOrEmpty(q.link))
                            sb.Append($" [[doc]]({q.link})");

                        sb.Append("\n");

                        if (q.extra != null)
                            q.extra.ForEach(e => sb.AppendLine($"    - {e}"));
                    }

                    sb.AppendLine();
                }
            }

            File.WriteAllText($"../README.md", sb.ToString());

            var sbsite = new StringBuilder();
            sbsite.AppendLine("---");
            sbsite.AppendLine("marp: true");
            sbsite.AppendLine("---");
            sbsite.AppendLine("");

            foreach (var module in root.modules)
            {

                foreach (var unit in module.units)
                {
                    var j = 1;

                    sbsite.AppendLine($"# {module.module} ([Learn module]({module.link}))\n");
                    sbsite.AppendLine($"## {unit.unit} ([Unit]({unit.link}))\n");
                    sbsite.AppendLine("");

                    if (!string.IsNullOrEmpty(unit.whiteboard))
                        sbsite.AppendLine($"![whiteboard]({unit.whiteboard})\n");

                    foreach (var q in unit.questions)
                    {
                        sbsite.Append($"{j++}. {q.question}");

                        if (q.links != null)
                            q.links.ForEach(link => sbsite.Append($" [[doc]]({link})"));

                        if (!string.IsNullOrEmpty(q.link))
                            sbsite.Append($" [[doc]]({q.link})");

                        sbsite.Append("\n");

                        if (q.extra != null)
                            q.extra.ForEach(e => sbsite.AppendLine($"    - {e}"));
                    }

                    sbsite.AppendLine("---");
                    sbsite.AppendLine("");

                }
            }

            File.WriteAllText($"../web/index.md", sbsite.ToString());

            Console.WriteLine("Finished");
        }
    }
}
