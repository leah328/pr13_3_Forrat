using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111111111133333333333333
{
    class Citizen
    {

        private string name;
        private string fam;
        private string ot;
        private string ser;
        private string num;
        private string city;
        public Citizen(string name, string fam, string ot, string ser, string num, string city)
        {
            this.name = name;
            this.fam = fam;
            this.ot = ot;
            this.ser = ser;
            this.num = num;
            this.city = city;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getFam()
        {
            return this.fam;
        }
        public void setFam(string fam)
        {
            this.fam = fam;
        }

        public string getOt()
        {
            return this.ot;
        }
        public void setOt(string ot)
        {
            this.ot = ot;
        }
        public string getSer()
        {
            return this.ser;
        }
        public void setSer(string ser)
        {
            this.ser = ser;
        }
        public string getNum()
        {
            return this.num;
        }
        public void setNum(string num)
        {
            this.num = num;
        }
        public string getCity()
        {
            return this.city;
        }
        public void setCity(string city)
        {
            this.city = city;
        }

    }
}
