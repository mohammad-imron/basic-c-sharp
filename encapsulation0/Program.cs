// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace Get_Set_0
{
	class access{
		private int paw;
		public void print(){
		Console.WriteLine("It is num " + paw);
		}

		public int Paw{
			get
			{
			return paw;
			}
			set
			{
			paw = value;
			}
		}
	}

	class Program{
		static void Main(string[] args){
		access ac = new access();
		Console.Write("\nWhat is your name");
		ac.Paw = int.Parse(Console.ReadLine())!;
		ac.print();
		Console.ReadLine();
		}
	}
}
