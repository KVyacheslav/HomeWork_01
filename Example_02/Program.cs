using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Домашнее задание

// Уровень сложности: средняя сложность
// * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
//              которых в отделе болжно остаться не более 30 работников

#endregion

namespace Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 40 сотрудников
            Repository repository = new Repository(40);

            // Печать в консоль всех сотрудников
            repository.Print("База данных до преобразования");

            // Увольнение всех работников с зарплатой более 0 рублей
            repository.DeleteWorkerBySalary(0);

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после первого преобразования");
        }
    }
}
