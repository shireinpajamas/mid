using System;
					
public class Program
{
	
	public static void Main()
	{
		string input_menu;
	  int  day_of_week,time_of_day;
		int[] menu={5,2,3}; //menu[0] =จำนวน Breakfast Set , menu[1] =จำนวน Weekend Set , menu[2] = จำนวน Coffee 
		day_of_week = int.Parse(Console.ReadLine());
		time_of_day = int.Parse(Console.ReadLine());
		while(true){
		input_menu = Console.ReadLine();
			if(input_menu == "End"){
			break;	
			}
			
		switch(input_menu){
			case "Breakfast Set":
				if(menu[0]<=0){
				Console.WriteLine("Sorry your order is out of stock");
				break;	
				}
				if(time_of_day > 11){
					Console.WriteLine("Sorry your order is not available");
					break;
				}
				menu[0]--;
				break;
			case "Weekend Set ":
				if(menu[1]<=0){
				Console.WriteLine("Sorry your order is out of stock");
				break;	
				}
				if(day_of_week > 5){
					Console.WriteLine("Sorry your order is not available");
					break;
				}
				menu[1]--;
				break;
			case "Coffee":
				if(menu[2]<=0){
				Console.WriteLine("Sorry your order is out of stock");
				break;	
				}
				menu[2]--;
				break;
			default:
			Console.WriteLine("Please enter a valid menu");	
			break;	
		}
			
		}
	}

}