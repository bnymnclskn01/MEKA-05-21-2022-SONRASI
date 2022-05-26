using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Interface
{
    public interface IDatabase
    {
        int login(string username, string password);
        void close();
        void addValue(string value);
        void deleteValue(string value);
        void getValue();
    }
}
