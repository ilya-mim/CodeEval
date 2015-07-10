using System;
using System.IO;
using System.Linq;

namespace Easy.SetIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line) continue;

                    var lists = line.Split(new[] {';'});
                    var firstList = lists[0].Split(new[] {','}).Select(int.Parse).ToArray();
                    var secindList = lists[1].Split(new[] {','}).Select(int.Parse).ToArray();

                    Console.WriteLine(string.Join(",", firstList.Intersect(secindList)));
                }
        }
    }
}