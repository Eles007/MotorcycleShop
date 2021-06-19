using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace MotorcycleShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppContext db = new AppContext();

            Company Company1 = new Company { Name = "BMW", Country = "Германия" };
            Company Company2 = new Company { Name = "Ducati", Country = "Италия" };
            Company Company3 = new Company { Name = "Honda", Country = "Япония" };
            Company Company4 = new Company { Name = "Kawasaki ", Country = "Япония" };
            Company Company5 = new Company { Name = "KTM", Country = "Австрия" };
                db.Companies.AddRange(Company1, Company2, Company3, Company4, Company5);
                db.SaveChanges();

            Motorcycle motorcycle1 = new Motorcycle { Name = "BMW R 1250 GS ADVENTURE", Price = 2051000, CompanyId = 1 };
            Motorcycle motorcycle2 = new Motorcycle { Name = "BMW R 1250 GS ADVENTURE", Price = 2051000, CompanyId = 1 };
            Motorcycle motorcycle3 = new Motorcycle { Name = "BMW R NINET SCRAMBLER", Price = 1318000, CompanyId = 1 };
            Motorcycle motorcycle4 = new Motorcycle { Name = "DUCATI XDIAVEL S - THRILLING BLACK", Price = 2542000, CompanyId = 2 };
            Motorcycle motorcycle5 = new Motorcycle { Name = "DUCATI XDIAVEL S - ICEBERG WHITE", Price = 2688000, CompanyId = 2 };
            Motorcycle motorcycle6 = new Motorcycle { Name = "DUCATI MULTISTRADA 1260 ENDURO", Price = 203200, CompanyId = 2 };
            Motorcycle motorcycle7 = new Motorcycle { Name = "HONDA CBR1000RR-R FIREBLADE", Price = 2215900, CompanyId = 3 };
            Motorcycle motorcycle8 = new Motorcycle { Name = "HONDA CB1000R BLACK EDITION", Price = 1429900, CompanyId = 3 };
            Motorcycle motorcycle9 = new Motorcycle { Name = "HONDA CRF450R 2021", Price = 852900, CompanyId = 3 };
            Motorcycle motorcycle10 = new Motorcycle { Name = "KAWASAKI Z900", Price = 915000, CompanyId = 4 };
            Motorcycle motorcycle11 = new Motorcycle { Name = "KAWASAKI KX450XC", Price = 915000, CompanyId = 4 };
            Motorcycle motorcycle12 = new Motorcycle { Name = "KAWASAKI VULCAN S ABS ЧЕРНЫЙ", Price = 765000, CompanyId = 4 };
            Motorcycle motorcycle13 = new Motorcycle { Name = "KTM 150 EXC TPI", Price = 869900, CompanyId = 5 };


            // добавление
                db.Motorcycles.AddRange(
                    motorcycle1, motorcycle2, motorcycle3,
                    motorcycle4, motorcycle5, motorcycle6,
                    motorcycle7, motorcycle8, motorcycle9,
                    motorcycle10, motorcycle11, motorcycle12, motorcycle13
                    );
                db.SaveChanges();
                motorcycle1.Company = null;


            //получение
            var companies = db.Companies
                    .Include(p => p.Motorcycles)
                    .ToList();
            Console.WriteLine("Список :");
            foreach (var company in companies)
            {
                Console.WriteLine($"Компания: {company.Name} Страна: {company.Country}");
                foreach (var motorcycle in company.Motorcycles)
                    Console.WriteLine($"Модель: {motorcycle.Name}  Цена: {motorcycle.Price}");
                Console.WriteLine("----------------------");

            }
        }
    }
}