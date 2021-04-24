using System;
					
public class Program
{
	
	public static void Main()
	{
	    String mode ="";
		float filmBackWidth;
		
		mode = Console.ReadLine();
		filmBackWidth = float.Parse(Console.ReadLine());
		
		if(filmBackWidth > 0){
			float fLength=0f,fov=0f;
			if(mode == "fLength"){
				while(fLength <= 0f){
					fLength = float.Parse(Console.ReadLine());
					Console.WriteLine("Invalid fLegnth. Please input again.");
				}
				fov =  float.Parse( (2 *(Math.Atan(double.Parse((filmBackWidth / 2 * fLength).ToString())))).ToString());
				Console.WriteLine("fLegnth = "+ fLength + ",fov = "+ fov);
			}
			else if(mode == "fov"){
				while(fov <= 0.1f && fov >= 6.28f){
					fov = float.Parse(Console.ReadLine());
					Console.WriteLine("Invalid fov. Please input again.");
				}
				fLength = float.Parse((filmBackWidth / (2* Math.Tan(double.Parse((fov/2).ToString())))).ToString());
				Console.WriteLine("fLegnth = "+ fLength + ",fov = "+ fov);
			}
		}
		else{
		Console.WriteLine("Invalid filmBackWidth. Please input again.")	;
		}
	}

}