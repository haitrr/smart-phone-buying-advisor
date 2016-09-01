using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneAdvisor
{
    class Rule
    {
        private string _name;
        private List<string> _conclution;
        private List<string> _suppose;
        public Rule()
        {
            _conclution = new List<string>();
            _suppose = new List<string>();
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public List<string> Conclution
        {
            get
            {
                return _conclution;
            }

            set
            {
                _conclution = value;
            }
        }

        public List<string> Suppose
        {
            get
            {
                return _suppose;
            }

            set
            {
                _suppose = value;
            }
        }
    }
}
