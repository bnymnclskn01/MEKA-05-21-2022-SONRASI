using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Interface.Manager
{
    public class DatabaseManager
    {
        private IDatabase _database;
        private string mark = new string('-', 6);
        public string value=null;
        public DatabaseManager(IDatabase database)
        {
            this._database = database;
        }
        public DatabaseManager()
        {

        }
        public void LoginDB()
        {
            string userName, Password;
            Console.Write("{0}\n<Veri tabanı Bağlantısı>\n{1}> Kullanıcı Adını Giriniz : ", mark, mark);
            userName = Console.ReadLine();
            Console.Write("Kullanıcı Şifresini Giriniz : ");
            Password = Console.ReadLine();
            if (_database.login(userName, Password) == 1)
                menu();
            else
                Console.Write("Bağlantı Bilgisi Yanlıştır\n{0}", mark);
        }
        public void CloseDB()
        {
            _database.close();
        }
        public void addValueDB(string value)
        {
            _database.addValue(value);
        }
        public void deleteValueDB(string value)
        {
            _database.deleteValue(value);
        }
        private void getValueDB()
        {
            _database.getValue(); 
        }
        private void menu()
        {
            int v;
            Console.Write("<-- Veritabanı İşlemleri -->\n{0}", mark);
            Console.Write("[1]\n <-- Veri Ekle -- >\n[2]\n<-- Veri Sil -->\n[3]\n <-- Veri Getir -->\n[4]\n Bağlantıyı Kes\n{0}", mark);
            Console.Write("Yapmak İstediğiniz İşlemi Seçiniz : ");
            v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    Console.Write("{0}\n Eklemek istediğiniz  veri : ", mark);
                    value=Console.ReadLine();
                    addValueDB(value);
                    Console.WriteLine(value);
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    Console.Clear();
                    deleteValueDB(value);
                    menu();
                    break;
                case 3:
                    Console.Clear();
                    getValueDB();
                    menu();
                    break;
                case 4:
                    CloseDB();
                    break;
                default:
                    break;
            }
        }
    }
}
