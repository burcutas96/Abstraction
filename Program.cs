using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Abstraction, bir sınıfın member'larından ihtiyacımız olanlarının getirilip
            //ihtiyacımız olmayanlarının getirilmemesidir. 


            User user = new User
            {
                Name = "Burcu",
                SurName = "Taş",
                Email = "burcutas636@gmail.com",
                Password = "123456789"
            };


            //Örneğin burada IUserValidateService interface'i ile sadece bu interface
            //başlığıyla ilgili memberlara ulaşmış olduk.
            IUserValidateService userManager1 = new UserManager();
            userManager1.ValidateUser(user);


            //Burada da IUserProcessService interface'i ile sadece bu interface
            //başlığıyla ilgili memberlara ulaşmış olduk.
            IUserProcessService userManager2 = new UserManager();
            userManager2.CreateUser(user);


            //Yani yapmak istediğimiz işle alakalı member'lara erişmek ve o işle hiçbir
            //alakası olmayan member'ları o nesneden soyutlanmak istiyorsak abstraction'lardan faydalanırız.
        }
    }
}
