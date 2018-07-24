using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestGitInVS2017
{
	public enum State
	{
		ToolBox,
		Menu,
		StatusBar
	}
	[Flags]
	public enum StateFlags
	{
		ToolBox,
		Menu,
		StatusBar
	}
	class Program
	{
		static void Main(string[] args)
		{
<<<<<<< HEAD
			Console.WriteLine("Hello World!");
=======
			Console.WriteLine(State.Menu | State.StatusBar);
			Console.WriteLine(StateFlags.Menu | StateFlags.StatusBar);
		}
	}
>>>>>>> AnotherBranch

	public class Base
	{
		public const string Id = "123-982-232";
		public static readonly string Date = "12/03/2010";
	}
	public class Derive : Base
	{
		public void ShowId()
		{
			Console.WriteLine(Id);
		}
		public void ShowDate()
		{
			Console.WriteLine(Date);
		}
	}

}
