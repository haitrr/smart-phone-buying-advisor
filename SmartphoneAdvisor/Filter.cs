using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneAdvisor
{
    class Filter
    {
        private int[] _price;
        private List<string> _manufacturer;
        private List<string> _os;
        private List<string> _color;
        private int _sim;
        private float[] _screen_size;
        private List<string> _screen_resolution;
        private int[] _internal_storage;
        private List<string> _CPU;
        private int[] _benchmark_score;
        private float[] _memory;
        private float[] _front_camera;
        private float[] _back_camera;
        private string _sdcard;
        private int[] _Battery;
        public Filter()
        {
            _manufacturer = new List<string>();
            _color = new List<string>();
            _os = new List<string>();
            _screen_resolution = new List<string>();
            _CPU = new List<string>();
            _screen_size = new float[2];
            _Battery = new int[2];
            _front_camera = new float[2];
            _back_camera = new float[2];
            _memory = new float[2];
            _benchmark_score = new int[2];
            _internal_storage = new int[2];
            _price = new int[2];
        }
        public void Reset()
        {
            _manufacturer = new List<string>();
            _color = new List<string>();
            _os = new List<string>();
            _screen_resolution = new List<string>();
            _CPU = new List<string>();
            _screen_size = new float[2];
            _Battery = new int[2];
            _front_camera = new float[2];
            _back_camera = new float[2];
            _memory = new float[2];
            _benchmark_score = new int[2];
            _internal_storage = new int[2];
            _price = new int[2];
        }
        public int[] Price
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

        public List<string> Manufacturer
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

        public List<string> Os
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

        public float[] Screen_size
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

        public List<string> Screen_resolution
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

        public int[] Internal_storage
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

        public List<string> CPU
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

        public int[] Benchmark_score
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

        public float[] Memory
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

        public float[] Front_camera
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

        public float[] Back_camera
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

        public int[] Battery
        {
            get
            {
                return _Battery;
            }

            set
            {
                _Battery = value;
            }
        }
    }
}
