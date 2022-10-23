using System;
using System.Collections.Generic;
using System.Text;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();

            string content = Console.ReadLine();

            List<string> comments = new List<string>();

            string comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                comments.Add(comment);

                comment = Console.ReadLine();
            }

            StringBuilder HTMLText = new StringBuilder();

            HTMLText.Append("<h1>\n");
            HTMLText.Append($"\t{title}\n");
            HTMLText.Append("</h1>\n");
            HTMLText.Append("<article>\n");
            HTMLText.Append($"\t{content}\n");
            HTMLText.Append("</article>\n");
            HTMLText.Append("<div>\n\t");
            HTMLText.Append(string.Join("\n</div>\n<div>\n\t", comments));
            HTMLText.Append("\n</div>");

            Console.WriteLine(HTMLText);
        }
    }
}
