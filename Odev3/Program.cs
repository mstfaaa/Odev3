using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev3
{
    class Program
    {
        static CustomerManager _customerManager = new CustomerManager();
        static void Main(string[] args)
        {
            string Islem;
            Console.WriteLine(">>>Kodlama.io Portala Hoşgeldiniz...<<<\n***************************************");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            do
            {
                Console.WriteLine("- Müşteri Ekle ---> E \n- Müşterileri Listele ---> L \n- Müşteri Sil ---> S");
                Islem = Console.ReadLine();
                Console.Clear();

                switch (Islem.ToUpper())
                {
                    case "E":
                        Customer customer = new Customer();
                        do
                        {
                            Console.Write("Müşteri TCKN(11): ");
                            customer.Tckn = Console.ReadLine();
                        } while (customer.Tckn.Length != 11);

                        Console.Write("Müşteri Adı: ");
                        customer.Name = Console.ReadLine();
                        Console.Write("Müşteri Soyadı: ");
                        customer.Surname = Console.ReadLine();

                        do
                        {
                            Console.Write("Müşteri Tel(10): ");
                            customer.Gsm = Console.ReadLine();
                        } while (customer.Gsm.Length != 10);

                        Console.Clear();

                        string resp = _customerManager.AddCustomer(customer);
                        Console.WriteLine(resp);

                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    case "L":
                        List<Customer> ctmrsList = _customerManager.GetCustomerList();
                        int x = 1;
                        foreach (Customer item in ctmrsList)
                        {
                            Console.WriteLine(x + ".\n" + "Tckn-> " + item.Tckn + "\n" + "Ad-> " + item.Name + "\n" + "Soyad-> " + item.Surname + "\n" + "Gsm-> " + item.Gsm + "\n");
                            x++;
                            Console.WriteLine("***********************");
                        }
                        break;

                    case "S":
                        Console.Write("Silmek istediğiniz Tckn'yi  Giriniz: ");
                        string tckn = Console.ReadLine();
                        Customer CustomerTckn = _customerManager.GetCustomer(tckn);

                        Console.Clear();

                        Console.WriteLine(CustomerTckn.Tckn + "\n" + CustomerTckn.Name + "\n" + CustomerTckn.Surname + "\n" + CustomerTckn.Gsm);

                        Console.WriteLine("***********************");
                        string cs = _customerManager.RemoveCustomer(tckn);
                        Console.WriteLine(cs);

                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }

            } while (true);
        }
    }
}
