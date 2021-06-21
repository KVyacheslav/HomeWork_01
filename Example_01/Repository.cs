using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{

    /// <summary>
    /// ����������� �������� � ��������� ������
    /// </summary>
    class Repository
    {
        /// <summary>
        /// ���� ������ ���
        /// </summary>
        static readonly string[] firstNames;

        /// <summary>
        /// ���� ������ �������
        /// </summary>
        static readonly string[] lastNames;

        /// <summary>
        /// ��������� ��������������� �����
        /// </summary>
        static Random randomize;

        /// <summary>
        /// ����������� �����������, � ������� "��������"
        /// ������ � ������ � �������� ��� ������ firstNames � lastNames
        /// </summary>
        static Repository()
        {
            randomize = new Random(); // ���������� � ������ ���������� ��������� �����

            // ���������� ���� � ���� ������ firstNames
            firstNames = new string[] {
                "�����",
                "�����",
                "��������",
                "�������",
                "������",
                "�����",
                "������",
            };

            // ���������� ������� � ���� ������ lastNames
            lastNames = new string[]
            {
                "�������",
                "�������",
                "���������",
                "���������",
                "�������",
                "������",
                "���������",
                "��������",
                "����������",
                "��������",
                "��������",
                "���������",
                "�������",
                "�������",
                "�������",
                "������",
                "�������",
                "������",
                "�����������",
                "��������",
                "��������"
            };
        }

        /// <summary>
        /// ���� ������ ����������, � ������� �������� 
        /// ���, �������, ������� � �������� ������� ����������
        /// </summary>
        public List<Worker> Workers { get; set; }

        /// <summary>
        /// �����������, ����������� ���� ������ Workers
        /// </summary>
        /// <param name="Count">���������� �����������, ������� ����� �������</param>
        public Repository(int Count)
        {
            this.Workers = new List<Worker>(); // ��������� ������ ��� �������� ���� ������ Workers

            for (int i = 0; i < Count; i++)    // ���������� ���� ������ Workers. ����������� Count ���
            {
                // ��������� ������ ��������� � ���� ������ Workers
                this.Workers.Add(
                    new Worker(
                        // �������� ��������� ��� �� ���� ������ ���
                        firstNames[Repository.randomize.Next(Repository.firstNames.Length)],

                        // �������� ��������� ��� �� ���� ������ �������
                        lastNames[Repository.randomize.Next(Repository.lastNames.Length)],

                        // ���������� ��������� ������� � ��������� 19 ��� - 60 ���
                        randomize.Next(19, 60),

                        // ���������� ��������� �������� � ��������� 10000��� - 80000���
                        randomize.Next(10000, 80000)
                        ));
            }
        }

        /// <summary>
        /// ����� ������ ���� ������ Workers � �������
        /// </summary>
        /// <param name="Text">��������������� �����, ������� ����� ��������� ����� ������� ����</param>
        public void Print(string Text)
        {
            Console.WriteLine(Text);    // ������ � ������� ���������������� ������

            // �������� ���� ������ ��� ������ � ������� �� DarkBlue
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // ������� ��������� ������� ���� ������
            Console.WriteLine($"{"���",15} {"�������",15} {"�������",10} {"��������",15}");

            // �������� ���� ������ ��� ������ � ������� �� Gray
            Console.ForegroundColor = ConsoleColor.Gray;


            foreach (var worker in this.Workers) //
            {                                    // �������� � ������� ���� ����������
                Console.WriteLine(worker);       //
            }                                    //

            Console.WriteLine($"�����: {this.Workers.Count}\n");    // ������� �����. ������� ���������� �����������
        }

        /// <summary>
        /// �����, ����������� ���������� � ��������� ������ ��������
        /// </summary>
        /// <param name="MaxSalary">������� �������� ���������, ������� ����� �������</param>
        public void DeleteWorkerBySalary(int MaxSalary)
        {
            this.Workers.RemoveAll(e => e.Salary > MaxSalary);//�������� ���������� ��� �������� ������ �������� MaxSalary
        }

        /// <summary>
        /// �����, ����������� ���������� � �������� ������
        /// </summary>
        /// <param name="CurrentName">��� ����������, ������� ����� �������</param>
        public void DeleteWorkerByName(string CurrentName)
        {
            this.Workers.RemoveAll(e => e.FirstName == CurrentName);//�������� ���������� ��� ��� ������������� ���������� CurrentName
        }
    }
}
