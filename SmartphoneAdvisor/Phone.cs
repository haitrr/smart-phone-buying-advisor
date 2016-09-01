using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneAdvisor
{
    class Phone
    {
        private string _name;
        private int _price;
        private string _manufacturer;
        private string _os;
        private List<string> _color;
        private int _sim;
        private float _screen_size;
        private string _screen_resolution;
        private int _internal_storage;
        private string _CPU;
        private int _benchmark_score;
        private float _memory;
        private float _front_camera;
        private float _back_camera;
        private string _sdcard;
        private int _battery;

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

        public int Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }

            set
            {
                _manufacturer = value;
            }
        }

        public string Os
        {
            get
            {
                return _os;
            }

            set
            {
                _os = value;
            }
        }

        public List<string> Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public int Sim
        {
            get
            {
                return _sim;
            }

            set
            {
                _sim = value;
            }
        }

        public float Screen_size
        {
            get
            {
                return _screen_size;
            }

            set
            {
                _screen_size = value;
            }
        }

        public int Internal_storage
        {
            get
            {
                return _internal_storage;
            }

            set
            {
                _internal_storage = value;
            }
        }

        public string Screen_resolution
        {
            get
            {
                return _screen_resolution;
            }

            set
            {
                _screen_resolution = value;
            }
        }

        public string CPU
        {
            get
            {
                return _CPU;
            }

            set
            {
                _CPU = value;
            }
        }

        public int Benchmark_score
        {
            get
            {
                return _benchmark_score;
            }

            set
            {
                _benchmark_score = value;
            }
        }

        public float Memory
        {
            get
            {
                return _memory;
            }

            set
            {
                _memory = value;
            }
        }

        public float Front_camera
        {
            get
            {
                return _front_camera;
            }

            set
            {
                _front_camera = value;
            }
        }

        public float Back_camera
        {
            get
            {
                return _back_camera;
            }

            set
            {
                _back_camera = value;
            }
        }

        public string Sdcard
        {
            get
            {
                return _sdcard;
            }

            set
            {
                _sdcard = value;
            }
        }

        public int Battery
        {
            get
            {
                return _battery;
            }

            set
            {
                _battery = value;
            }
        }
    }
}