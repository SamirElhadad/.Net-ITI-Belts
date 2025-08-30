using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Manager : Employee
    {
        public string ManageTeam { get; set; }
        public Manager(string name, int salary, string manageTeam) : base(name, salary)
        {
            ManageTeam = manageTeam;
        }
        public void Manage()
        {
            Console.WriteLine($"{Name} is managing the {ManageTeam} team with salary {Salary}.");
        }
    }
    
    
}
