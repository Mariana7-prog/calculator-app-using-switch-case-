namespace calculator_app_bro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; // here we declare our variables for our calculator app ( we use doubles ( decimal variables e.g 0, 5, -3 , 42 ) ) 
            double num2 = 0;
            double result=0; // here we put the result ( is initialise with 0 )

            
            
            
            
            
            
            Console.WriteLine("Welcome to calculator app!"); // here we put some text 
            Console.WriteLine("-^-^-^-^-^-^-^-^-^-^-^"); // we can add some symbols ass well to make it more fun
            Console.WriteLine("Calculator Program"); // here some text as well 
            Console.WriteLine("<3 <3 <3 <3 <3 <3 <3 <3 "); // here the same  
           
            Console.WriteLine("Enter number 1 ; "); // here we ask for some user imput 
            num1 =Convert.ToDouble (Console.ReadLine()); // here we  take the user input, we convert it to a double and we stored into the variable num 1 

            Console.Write("Enter number 2 ; ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option"); // here we add some options for the user to choose 
            Console.WriteLine("\t+ : Add"); //use "/t" to add some spaces at the beginning
            Console.WriteLine("\t+ : Subtract"); // here we have the option for the user to choose
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");


            switch(Console.ReadLine()) // we create a swich which is gonna read our user imput 
            {

                case "+":
                    result=num1 +num2;
                    Console.WriteLine( $" Your result : {num1}  +  {num2} = "+ result ); // here we do our cases ( for example here we have (+ adding )
                    break; //The break statement stops a switch from running into the next case.

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($" Your result : {num1}  -  {num2} = " + result); // here we do the same but we change from + to - 
                    break;
                
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($" Your result : {num1}  *  {num2} = " + result); // - || -
                    
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($" Your result : {num1}  / {num2} = " + result); // - || -
                    break;

                default: // default is used when the user do not choose a option form the above 
                 
                    Console.WriteLine( "That was not a valid option ");
                    break;


            }
                

         Console.ReadKey();


        }
    }
}
