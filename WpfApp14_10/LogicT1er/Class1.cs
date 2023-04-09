using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataTier1;

namespace LogicT1er
{
    public class Заведение
    {
        private List<Списочная_позиция> _работник = new List<Списочная_позиция>();
        public Заведение()
        {
            List<Names> tmp = AllWorkers.TakeAllWorkers();
            foreach (var t in tmp)
            {
                _работник.Add(new Списочная_позиция(t));
            }
        }
        public List<Списочная_позиция> Список_Работников
        {
            get { return _работник; }
        }
        public string Наименование_УЗ
        {
            get { return "Epample"; }
        }
        public float ФОТ
        {
            get
            {
                return _работник.Sum(p => p.ФОТ);
            }
        }
        public float Средняя
        {
            get
            {
                return _работник.Sum(p => p.Средняя);
            }
        }
    }

    public class Списочная_позиция
    {
        private Names _работник;
        public Списочная_позиция(Names p)
        {
            _работник = p;
        }
        public String Имя
        {
            get { return _работник.Name; }
            set { _работник.Name = value; }
        }
        public String Должность
        {
            get { return _работник.Post; }
            set { _работник.Post = value; }
        }
        public String Кафедра
        {
            get { return _работник.Department; }
            set { _работник.Department = value; }
        }
        public float Зарплата
        {
            get { return _работник.Wage; }
            set { _работник.Wage = value; }
        }
        public string Представление
        {
            get
            {
                return _работник.Name + " " + _работник.Post + " "
                    + _работник.Department + " " + _работник.Wage.ToString("");
            }
        }
        public float ФОТ
        {
            get 
            {
                float a = 0;
                if(_работник.Wage!= null)
                { 
                    a+= _работник.Wage;
                }
                return a; 
            }
        }
        public float Средняя
        {
            get
            {
                float a = 0;
                int i = 0;
                if (_работник.Wage != null)
                {
                    a += _работник.Wage;
                    i++;
                }
                return a/5;
            }
        }
    }
}
