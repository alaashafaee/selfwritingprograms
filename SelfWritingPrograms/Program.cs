using System;
class B
{
    static void Main()
    {
        string[] S = {
"        Console.WriteLine(\"using System;\");",
"        Console.WriteLine(\"class \" + (isA ? \"B\" : \"A\"));",
"        Console.WriteLine(\"{\");",
"        Console.WriteLine(\"    static void Main()\");",
"        Console.WriteLine(\"    {\");",
"",
"        Console.WriteLine(\"        string[] S = {\");",
"        foreach (string line in S)",
"        {",
"            string escapedLine = line.Replace(@\"\\\", @\"\\\\\")",
"                .Replace(\"\\\"\", \"\\\\\\\"\");",
"            Console.WriteLine(\"\\\"{0}\\\",\", escapedLine);",
"        }",
"        Console.WriteLine(\"        };\");",
"        Console.WriteLine(\"        bool isA = \" + (isA ? \"false\" : \"true\") + \";\");",
"",
"        foreach (string line in S) Console.WriteLine(line);",
"",
"        Console.WriteLine(\"    }\");",
"        Console.WriteLine(\"}\");",
"",
"        Console.ReadKey();",
        };
        bool isA = false;
        Console.WriteLine("using System;");
        Console.WriteLine("class " + (isA ? "B" : "A"));
        Console.WriteLine("{");
        Console.WriteLine("    static void Main()");
        Console.WriteLine("    {");

        Console.WriteLine("        string[] S = {");
        foreach (string line in S)
        {
            string escapedLine = line.Replace(@"\", @"\\")
                .Replace("\"", "\\\"");
            Console.WriteLine("\"{0}\",", escapedLine);
        }
        Console.WriteLine("        };");
        Console.WriteLine("        bool isA = " + (isA ? "false" : "true") + ";");

        foreach (string line in S) Console.WriteLine(line);

        Console.WriteLine("    }");
        Console.WriteLine("}");

        Console.ReadKey();
    }
}
