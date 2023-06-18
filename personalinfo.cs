using System;
using System.Collections.Generic;

namespace PersonalFinanceManager
{
    class Program
    {
        static List<double> incomes = new List<double>();
        static List<double> expenses = new List<double>();

        static void Main(string[] args)
        {
            Console.WriteLine("Kişisel Finans Yöneticisine Hoş Geldiniz!");
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Gelir Ekle");
                Console.WriteLine("2. Gider Ekle");
                Console.WriteLine("3. Toplam Gelirleri Görüntüle");
                Console.WriteLine("4. Toplam Giderleri Görüntüle");
                Console.WriteLine("5. Bütçe Durumu Görüntüle");
                Console.WriteLine("6. Çıkış");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddIncome();
                        break;
                    case "2":
                        AddExpense();
                        break;
                    case "3":
                        DisplayTotalIncomes();
                        break;
                    case "4":
                        DisplayTotalExpenses();
                        break;
                    case "5":
                        DisplayBudgetStatus();
                        break;
                    case "6":
                        isRunning = false;
                        Console.WriteLine("Programdan çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void AddIncome()
        {
            Console.Write("Yeni gelir miktarını girin: ");
            double income = Convert.ToDouble(Console.ReadLine());
            incomes.Add(income);
            Console.WriteLine("Gelir başarıyla eklendi.");
        }

        static void AddExpense()
        {
            Console.Write("Yeni gider miktarını girin: ");
            double expense = Convert.ToDouble(Console.ReadLine());
            expenses.Add(expense);
            Console.WriteLine("Gider başarıyla eklendi.");
        }

        static void DisplayTotalIncomes()
        {
            double totalIncomes = CalculateTotal(incomes);
            Console.WriteLine("Toplam gelirler: " + totalIncomes);
        }

        static void DisplayTotalExpenses()
        {
            double totalExpenses = CalculateTotal(expenses);
            Console.WriteLine("Toplam giderler: " + totalExpenses);
        }

        static void DisplayBudgetStatus()
        {
            double totalIncomes = CalculateTotal(incomes);
            double totalExpenses = CalculateTotal(expenses);
            double budgetStatus = totalIncomes - totalExpenses;
            
            Console.WriteLine("Bütçe Durumu: " + budgetStatus);
        }

        static double CalculateTotal(List<double> values)
        {
            double total = 0;

            foreach (double value in values)
            {
                total += value;
            }

            return total;
        }
    }
}
