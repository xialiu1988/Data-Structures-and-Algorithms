using System;
using Xunit;
using left_join;
using System.Collections;
using System.Collections.Generic;

namespace leftjoinTDD
{
    public class UnitTest1
    {/// <summary>
    /// both table has food,can combine the values
    /// </summary>
        [Fact]
        public void cancombinethevalues()
        {
            Hashtable h1 = new Hashtable();
            h1.Add("food", "apple");

            Hashtable h2 = new Hashtable();
            h2.Add("food", "kiwi");
    
        List<string> list= Program.Leftjointables(h1, h2);
            string expected = "food:apple,kiwi";
            //string expected2 ="drink:coke,water";
            //string expected3 = "desert:cake,null";
            Assert.Equal(expected,list[0]);
            //Assert.Equal(expected2, list[1]);
            //Assert.Equal(expected3, list[2]);
        }

        /// <summary>
        /// left table has food , so the right table value will be null
        /// </summary>
        [Fact]
        public void canprintvalue()
        {
            Hashtable h1 = new Hashtable();
            h1.Add("food", "apple");
     
            Hashtable h2 = new Hashtable();
            h2.Add("drink", "kiwi");

            List<string> list = Program.Leftjointables(h1, h2);
            string expected = "food:apple,null";
            Assert.Equal(expected, list[0]);
 
        }

        /// <summary>
        /// left table has drink, so right table value will be null for the drink
        /// </summary>
        [Fact]
        public void cancombinethevaluesbasedonlefttable()
        {
            Hashtable h1 = new Hashtable();

            h1.Add("drink", "coke");
           
            Hashtable h2 = new Hashtable();
            h2.Add("food", "kiwi");
 
            List<string> list = Program.Leftjointables(h1, h2);

            string expected2 ="drink:coke,null";
         

            Assert.Equal(expected2, list[0]);

        }


    }
}
