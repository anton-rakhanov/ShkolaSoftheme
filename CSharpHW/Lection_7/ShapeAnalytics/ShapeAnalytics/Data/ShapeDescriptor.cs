using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAnalytics.Data
{
    public class ShapeDescriptor
    {

        private List<Point> _coordinates = new List<Point>();

        private string _shapeType;

        public string ShapeType
        {
            get { return _shapeType; }
        }

        public ShapeDescriptor(Point point1)
        {
            _coordinates.Add(point1);
            FindOutShapeType(this._coordinates);
        }

        public ShapeDescriptor(Point point1, Point point2)
        {
            _coordinates.Add(point1);
            _coordinates.Add(point2);
            FindOutShapeType(this._coordinates);
        }

        public ShapeDescriptor(Point point1, Point point2, Point point3)
        {
            _coordinates.Add(point1);
            _coordinates.Add(point2);
            _coordinates.Add(point3);
            FindOutShapeType(this._coordinates);
        }

        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4)
        {
            _coordinates.Add(point1);
            _coordinates.Add(point2);
            _coordinates.Add(point3);
            _coordinates.Add(point4);
            FindOutShapeType(this._coordinates);
        }

        private void FindOutShapeType(List<Point> coordinates)
        {
            switch(coordinates.Count)
            {
                case 1:
                    {
                        _shapeType = "It's a point";
                        break;
                    }
                case 2:
                    {
                        _shapeType = "It's a line";
                        break;
                    }
                case 3:
                    {
                        _shapeType = "It's some sort of triangle";
                        break;
                    }
                case 4:
                    {
                        _shapeType = "It's some sort of 4 point shape";
                        break;
                    }
            }
        }
    }
}
