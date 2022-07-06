//ex1   
using System;

public class Test
{
    public static void Main(string[] args)
    {
        String letter1,letter2,letter3; 
        
        Console.WriteLine ("Input letter:");
        letter1 = Console.ReadLine();
        Console.WriteLine ("Input letter:");
        letter2 = Console.ReadLine();
        Console.WriteLine ("Input letter:");
        letter3 = Console.ReadLine();
        Console.WriteLine("{2} {1} {0}",letter1,letter2,letter3);
    }
}

//1.2
using System;

public class Test
{
    public static void Main()
    {
        String  username,password;
        int i=0 , j=0;

       do
{
Console.Write("Input a username: ");
username = Console.ReadLine();
 
Console.Write("Input a password: ");
password = Console.ReadLine();
if( username == "naey" && password == "1234" )
{
    i=1;
    j=3;
}

else
{
    i=0;
    j++;
}
}
while (( username != "username" || password != "password" )
        && (j != 3));
        if (i == 0)
        {
            Console.Write("\nLogin more than three times. Try later!\n\n");
        }
        else  
        if(i==1)
        {
            Console.Write("\nPassword entered successfull!\n\n");	}         
    }
}
// ex1.3
using System;

public class Test
{
    public static void Main()
    {
       double r,p;
       double PI = 3.14;

    Console.Write("Input a radius:");
    r = Convert.ToDouble(Console.ReadLine());
    p = 2 * PI * r;
    Console.WriteLine("Parimeter is:{0}",p);
    }
}
    
//1.4
using System;
public class Exercise7
{
  public static void Main()
  {
    float distance;
    float hour, min, sec;
     
    float timeSec;
    float kph, mph;
     
    Console.Write("Input distance(metres): ");
    distance = Convert.ToSingle(Console.ReadLine());
    Console.Write("Input timeSec(hour): ");
    hour = Convert.ToSingle(Console.ReadLine());
    Console.Write("Input timeSec(minutes): ");
    min = Convert.ToSingle(Console.ReadLine());
    Console.Write("Input timeSec(seconds): ");
    sec = Convert.ToSingle(Console.ReadLine());
     
    timeSec = (hour*3600) + (min*60) + sec;
    kph = (distance/1000.0f)/(timeSec/3600.0f);
    mph = kph / 1.609f;
     
    Console.WriteLine("Your speed in km/h is {0}", kph);
    Console.WriteLine("Your speed in miles/h is {0}", mph);
  }
}
    
//1.5






//2.1
using System;
public class Test
{
  public static void Main()
  {
 int integer1,integer2;
 
    Console.Write("Input Interger1: ");
    integer1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input Interger2: ");
    integer2 = Convert.ToInt32(Console.ReadLine());
   
   if ( integer1 == integer2) 
    Console.WriteLine("They are equal. {0} and {1} ",integer1,integer2);
else
    Console.WriteLine("They are not equal. {0} and {1}",integer1,integer2);
  }
  
  
}


//2.2


