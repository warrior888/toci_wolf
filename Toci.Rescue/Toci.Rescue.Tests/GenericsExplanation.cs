using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Toci.Rescue.Tests
{
    public class GenExp : GenericsExplanation
    { }

    public interface IShowdown<T> { 
        T Element { get; set; }
    }

    public class Jaja<T> : IShowdown<T>

    {
        public T Element { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
    public class Kura<T> : Jaja<T>
    {
        
    }

    public class dupa : Kura<GenExp>
    {
        void sraka()
        {
            Dictionary<string, Func<Jaja<GenericsExplanation>>> pairs = new Dictionary<string, Func<Jaja<GenericsExplanation>>>() {
                { "fdasgfds", () => new Kura<GenericsExplanation>() },
            };
            //Func<Kura<GenericsExplanation>> func = () => new Kura<GenExp>();
            //IShowdown<GenericsExplanation> d = func();
        }
    }

    //public class Kogut : 

    [TestClass]
    public class GenericsExplanation
    {
        [TestMethod]
        public void List()
        {
            List<string> people = new List<string>()
            {
                "iwona",
                "wojtek",
                "piotrus"
            };

            List<int> primeNumbers = new List<int>()
            {
                11,13,17,19,23
            };

            people.Sort();

            Dictionary<int, string> months = new Dictionary<int, string>()
            {
                { 8, "sierpien"},
                { 12, "grudzien"}
            };

            string data = "1984-08-08";

            string month = data.Substring(5, 2);
            int miesiac = 0;
            int.TryParse(month, out miesiac);

            string ourMonth = months.ContainsKey(miesiac) ? months[miesiac] : "";
        }
    }
}
