﻿using System;
using SalaryContratcManager1.Entities.Enums;
using System.Collections.Generic;



namespace SalaryContratcManager1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contratc in Contracts)
            {

                if (contratc.Date.Year == year && contratc.Date.Month == month)
                {
                    sum += contratc.TotalValue();
                }

            }
            return sum;

        }
    }
}

