using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class DymArray
    {
        private double[] _arr = Array.Empty<double>();
        private int _capacity;
        public int Size { get; private set; }


        public DymArray() { }
        public DymArray(int capacity)
        {
            if (capacity < 0) throw new Exception("Задана некорректная мощность массива");

            if (capacity == 0)
            {
                _capacity = 0;
                Size = 0;
            }
            else
            {
                _arr = new double[capacity];
                _capacity = capacity;
            }
        }
        public DymArray(double[] arr)
        {
            Size = arr.Length;
            _capacity = arr.Length;
            AddSpace(arr.Length);
            arr.CopyTo(_arr, 0);
        }


        public int Count => Size;


        private double GetElement(int index)
        {
            if (index < 0 || index >= Size) throw new Exception("Задан некорректный индекс");
            return _arr[index];
        }
        private void SetElement(double value, int index)
        {
            if (index < 0 || index >= Size) throw new Exception("Задан некорректный индекс");
            _arr[index] = value;
        }
        public double this[int index]
        {
            get => GetElement(index);
            set => SetElement(value, index);
        }


        private void AddSpace(int size = 1)
        {
            if (Size != 0)
            {
                _capacity = Convert.ToInt32(_capacity * 1.6 + 1);
            }
            else
            {
                if (size != 1)
                {
                    _capacity = Convert.ToInt32(size * 1.6 + 1);
                }
                else
                {
                    _capacity = size;
                }
            }
            double[] tmp = new double[_capacity];
            _arr.CopyTo(tmp, 0);
            _arr = new double[tmp.Length];
            _arr = tmp;
        }


        public void AppendToEnd(double value)
        {
            if (Size < _capacity)
            {
                _arr[Size++] = value;
            }
            else
            {
                AddSpace();
                _arr[Size++] = value;
            }
        }


        public void DeleteTail()
        {
            Size--;
        }


        public void Insert(double value, int index)
        {
            if (Size < _capacity)
            {
                Size++;
            }
            else
            {
                AddSpace();
            }
            for (int i = Size; i >= index; i--)
            {
                _arr[i] = _arr[i - 1];
            }
            _arr[index] = value;
        }


        public override string ToString()
        {
            return String.Join(" ", _arr[0..Size]);
        }


        public void RemoveAt(int index)
        {
            for (int i = index; i < Size; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            Size--;
        }


        public void RemoveAll(double value)
        {
            for (int i = 0; i < Size; i++)
            {
                if (_arr[i] != value)
                {
                    continue;
                }
                RemoveAt(i);
            }
        }


        public int MaxIndex()
        {
            int index = 0;
            for (int i = 0; i < Size; i++)
            {
                if (_arr[index] < _arr[i])
                {
                    index = i;
                }
            }
            return index;
        }

    }
}
