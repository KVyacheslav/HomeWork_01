using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Домашнее задание

// Уровень сложности: сложно
// ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
//               чья зарплата превышает 30000руб

#endregion

namespace Example_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 40 сотрудников
            Repository repository = new Repository(50);

            // Печать в консоль всех сотрудников
            repository.Print("База данных до преобразования");

            // Увольнение всех работников с зарплатой более 30000 рублей
            repository.DeleteWorkerBySalary(30000);

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после первого преобразования");



        }
    }
}
