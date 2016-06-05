using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneYourCar.Data
{
    public class Car
    {
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private Colors _color;

        public Colors Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Car(string model = "Cabriolet", int year = 1987, Colors color = Colors.Black)
        {
            this._model = model;
            this._year = year;
            this._color = color;
        }

    }
}
