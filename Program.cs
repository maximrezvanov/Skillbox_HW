using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //// Создание базы данных из 20 сотрудников
            //Repository repository = new Repository(20);

            //// Печать в консоль всех сотрудников
            //repository.Print("База данных до преобразования");

            //// Увольнение всех работников с именем "Агата"
            //repository.DeleteWorkerByName("Агата");

            //// Печать в консоль сотрудников, которые не попали под увольнение
            //repository.Print("База данных после первого преобразования");

            //// Увольнение всех работников с именем "Аделина"
            //repository.DeleteWorkerByName("Аделина");

            //// Печать в консоль сотрудников, которые не попали под увольнение
            //repository.Print("База данных после второго преобразования");

            #region task 1 
            Repository repository = new Repository(20);
            repository.Print("в отделе не более 20 сотрудников");
            #endregion

            #region task 2.
            repository = new Repository(40);
            repository.Print("Задание 2 (40 сотрудников, несколько увольнений)");
            repository.DeleteWorkerByCount(5);
            repository.Print("увольнение 1");
            repository.DeleteWorkerByCount(5);
            repository.Print("увольнение 2");
            #endregion

            #region task 3.
            repository = new Repository(50);
            repository.Print("Задание 3, 50 сотрудников, уволить всех у кого зп > 30k");
            repository.DeleteWorkerBySalary(30000);
            repository.Print("База данных после увольнения работников чья зарплата превышает 30000руб");
            #endregion

            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб




            #endregion

        }
    }
}
