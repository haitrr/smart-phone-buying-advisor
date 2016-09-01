using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneAdvisor
{
    class Customer
    {
        private int _age;
        private string _profession;
        private List<string> _hobbies;
        private string _gender;
        public Customer()
        {
            _hobbies = new List<string>();
        }
        public void Reset()         //lam moi lai
        {
            _hobbies = new List<string>();
            _profession = "";
            _gender = "";
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public string Profession
        {
            get
            {
                return _profession;
            }

            set
            {
                _profession = value;
            }
        }

        public List<string> Hobbies
        {
            get
            {
                return _hobbies;
            }

            set
            {
                _hobbies = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
    }
}
