using System;
					
public class Program
{
	
	public static void Main()
	{
		string input;
		int[] input_num = new int[3];
		input = Console.ReadLine();
		for(int i=0;i<=2;i++){
			input_num[i] = Int32.Parse(Console.ReadLine());	
		}
		for(int i=1;i<input_num[2]+1;i++){
		for(int k=1;k<input_num[1]+1;k++){
		    Console.WriteLine();
		for(int j=0;j<input_num[0];j++){
				Console.Write(input);
		}
		}
		}
		
	}
}

