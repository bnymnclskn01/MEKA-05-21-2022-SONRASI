using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Interface.ClassMetot
{
    public class OracleDatabaseManager : IDatabase
    {
        private string value, userName = "oracle", Password = "admin", mark = new string('-', 6);
        public void addValue(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.Write("{0}\n-> Oracle veritabanı bağlantızı başarılı bir şekilde sonlandırdınız,\n{1}", mark, mark);
        }

        public void deleteValue(string value)
        {
            this.value = null;
            Console.Write("{0}\n-> Oracle veritabanından veriyi başarılı bir şekilde sildiniz.,\n{1}", mark, mark);
        }

        public void getValue()
        {
            if (value != null)
            {
                Console.Write("{0}\n istediğiniz doğrultuda veritabanındaki bilgi {1} verisini başarılı bir şekilde getirdik.\n {2}", mark, value, mark);
            }
            else
            {
                Console.Write("{0}\n-> Oracle veritabanından veriyi başarılı bir şekilde getiremedik lütfen tekrar deneyiniz.,\n{1}", mark, mark);
            }
        }

        public int login(string username, string password)
        {
            if (userName == username && Password == password)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
