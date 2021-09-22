﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    class Departament
    {
        public int idDeportament;
        public int salary;
        static public int idEmployee = 0;
        public List<Departament> departaments;
        public List<Employee> employees;
        public string Title { get; set; }
        public Departament(string title,int idDeportament)
        {
            this.Title = title;
            this.idDeportament = idDeportament;
            this.departaments = new List<Departament>();
            this.employees = new List<Employee>();
        }
        public void AddIntern()
        {
            idEmployee++;
            employees.Add(new Intern(idEmployee));
        }

        public void AddWorker()
        {
            idEmployee++;
            employees.Add(new Worker(idEmployee));
        }
        public void AddManager()
        {
            idEmployee++;
            employees.Add(new Manager(idEmployee));
        }

        public void AddDepartament(string title)
        {
            idDeportament++;
            departaments.Add(new Departament(title,idDeportament));
        }

        public override string ToString()
        {
            return idDeportament+" "+Title;
        }

        
    }
}

