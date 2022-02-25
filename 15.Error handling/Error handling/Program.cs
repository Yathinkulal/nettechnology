using System;

namespace Error_handling
{
    class ExcepyionHandling
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.displayAge();
            }
            catch(AgelsNegtiveException e)
            {
                Console.WriteLine("AgelsNegativeException:{0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Exception of finally block is done.");
            }
        }
    }
}
public class AgelsNegtiveException:Exception
{
    public AgelsNegtiveException(string message):base(message)
    {

    }
}
public class Age
{
    int age = -5;
    public void displayAge()
    {
        if(age<0)
        {
            throw (new AgelsNegtiveException("Age cannot be negative"));

        }
        else
        {
            Console.WriteLine("Age is:{0}",age);
           
        }
    }
}
