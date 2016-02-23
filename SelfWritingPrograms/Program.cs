using System;
class M1
{
    static void Main()
    {
        string[] S = {
"        Console.WriteLine(\"using System;\");",
"        Console.WriteLine(\"class \" + (isM1 ? \"M2\" : \"M1\"));",
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
"        Console.WriteLine(\"        bool isM1 = \" + (isM1 ? \"false\" : \"true\") + \";\");",
"",
"        foreach (string line in S) Console.WriteLine(line);",
"",
"        Console.WriteLine(\"    }\");",
"        Console.WriteLine(\"}\");",
"",
"        Console.ReadKey();",
        };
        bool isM1 = true;
        Console.WriteLine("using System;");
        Console.WriteLine("class " + (isM1 ? "M2" : "M1"));
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
        Console.WriteLine("        bool isM1 = " + (isM1 ? "false" : "true") + ";");

        foreach (string line in S) Console.WriteLine(line);

        Console.WriteLine("    }");
        Console.WriteLine("}");

        Console.ReadKey();
    }
}