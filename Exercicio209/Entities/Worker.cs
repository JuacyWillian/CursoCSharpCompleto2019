using System.Collections.Generic;
using Exercicio209.Entities.Enums;

namespace Exercicio209.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; private set; }
        public Department Department { get; set; }

        public WorkerLevel Level { get; set; }

        public Worker(string name, double baseSalary, Department department, WorkerLevel level)
        {
            Name = name;
            BaseSalary = baseSalary;
            Department = department;
            Level = level;
            Contracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double incomes = BaseSalary;
            foreach (HourContract c in Contracts)
            {
                if (c.Date.Year == year && c.Date.Month == month)
                    incomes += c.TotalValue();
            }
            return incomes;
        }

        override public string ToString()
        {
            return Name;
        }
    }
}