using System;

namespace Multi_bracket_validation
{
   public class Program
    {
      public static void Main(string[] args)
        {

            string s = "{{6789}}]]";
         bool boo= MultiBracketValidation(s);
            Console.WriteLine(s);
            Console.WriteLine("=============");
            if ( boo==true) { Console.WriteLine("True!"); }

            else { Console.WriteLine("False! "); }
        }


        public static bool MultiBracketValidation(string input)
        {

            Stack stack = new Stack();

            for(int i = 0; i <input.Length; i++)
            {

                if (input[i] == '[' || input[i] == '{' || input[i] == '(')
                {
                    stack.Push(input[i]);

                }

                if (input[i] == ']')
                {
                    if (stack.Top!=null && stack.Top.Val == '[') { stack.Pop(); }
                    else { return false; }
                   
                }

                if (input[i] == '}')
                {
                    
                    if (stack.Top != null && stack.Top.Val == '{') { stack.Pop(); }
                    else { return false; }

                }

                if (input[i] == ')')
                {
                    
                    if (stack.Top != null && stack.Top.Val== '(') { stack.Pop(); }
                    else { return false; }

                }
            }

            if (stack.Top== null) return true;
           else return false;
        }


    }
}
