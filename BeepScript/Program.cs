using System;
using System.Threading;
using System.IO;

namespace BeepScript
{
    class MainClass
    {
		public static void READ_LINES(string[] LINES)
		{
			for (int i = 0; LINES.Length > i; i++)
			{
				READ_LINE(LINES[i]);
			}
		}

		public static void READ_LINE(string LINE_STR)
		{
			string[] LINE_ARR = LINE_STR.Split(' ');
			switch (LINE_ARR[0])
			{
				case "PLAY":
					Console.Beep(Int32.Parse(LINE_ARR[1]), Int32.Parse(LINE_ARR[2]));
					break;
				case "WAIT":
					Thread.Sleep(Int32.Parse(LINE_ARR[1]));
					break;
			}
		}

        public static void Main(string[] args)
        {
			string[] LINES_FROM_FILE = File.ReadAllLines(args[0]);
			READ_LINES(LINES_FROM_FILE);
        }
    }
}
