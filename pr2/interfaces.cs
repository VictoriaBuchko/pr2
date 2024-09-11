using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }
    public interface IMath
    {
        int Max();
        int Min();
        double Avg();
        bool Search(int valueToSearch);
    }
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

}
