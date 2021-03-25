using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<T, S>
    {
        T[] _key;
        S[] _value;



        public MyDictionary()
        {
            _key = new T[0];
            _value = new S[0];
        }

        public void Add(T key, S value)
        {
            T[] _tempkey = _key;
            S[] _tempvalue = _value;
            _key = new T[_key.Length + 1];
            _value = new S[_key.Length + 1];

            for (int i = 0; i < _tempkey.Length; i++)
            {
                _key[i] = _tempkey[i];

            }

            for (int i = 0; i < _tempvalue.Length; i++)
            {
                _value[i] = _tempvalue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }


        
        public void GetAll()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine($"{_key[i]}  {_value[i]}");
            }
        }

    }
}
