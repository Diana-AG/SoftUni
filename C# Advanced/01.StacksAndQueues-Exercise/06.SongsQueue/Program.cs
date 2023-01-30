using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);


            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < songs.Length; i++)
            {
                if (queue.Contains(songs[i]))
                {
                    continue;
                }

                queue.Enqueue(songs[i]);
            }

            while (queue.Count > 0)
            {
                string line = Console.ReadLine();
                
                switch (line)
                {
                    case "Play":
                        queue.Dequeue();
                        break;

                    case "Show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;

                    default:
                        string song = line.Substring(line.IndexOf(' ') + 1);
                        
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(song);
                        }
                        break;
                }
            }

            Console.WriteLine("No more songs!");

            //string[] songs = Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //Queue<string> queue = new Queue<string>();

            //for (int i = 0; i < songs.Length; i++)
            //{
            //    if (queue.Contains(songs[i]))
            //    {
            //        continue;
            //    }

            //    queue.Enqueue(songs[i]);
            //}

            //while (queue.Count > 0)
            //{
            //    string[] commandParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //    switch (commandParts[0])
            //    {
            //        case "Play":
            //            queue.Dequeue();
            //            break;

            //        case "Add":

            //            string song = string.Empty;
            //            for (int i = 1; i < commandParts.Length; i++)
            //            {
            //                song += $"{commandParts[i]} ";
            //            }
            //            song = song.TrimEnd();

            //            if (queue.Contains(song))
            //            {
            //                Console.WriteLine($"{song} is already contained!");
            //            }
            //            else
            //            {
            //                queue.Enqueue(song);
            //            }
            //            break;

            //        case "Show":
            //            Console.WriteLine(string.Join(", ", queue));
            //            break;
            //    }
            //}

            //Console.WriteLine("No more songs!");
        }
    }
}
