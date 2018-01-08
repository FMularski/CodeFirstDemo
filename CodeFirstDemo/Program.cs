using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new WorkersDbContext();

            context.Workers.Add(new Worker
            {
                FirstName = "Filip",
                LastName = "Mularski",
                PasscardNumber = "012Q-FM"
            });
            context.SaveChanges();
            
        }
    }
}
