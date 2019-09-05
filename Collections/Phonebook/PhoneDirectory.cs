using System;
using System.Collections;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> _data;
        public int _dataCount = 0;

        public PhoneDirectory(string name, string number)
        {
            _data = new SortedDictionary<string, string>();
            _data.Add(name, number);
            _dataCount++;

        }

        public void PrintPhoneDirectory()
        {
            foreach (KeyValuePair<string, string> kvp in _data)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }


        private int Find(string name)
        {

            foreach (KeyValuePair<string, string> pair in _data)
            {
                if (_data.ContainsKey(name))
                {
                    Console.WriteLine(true);
                }
            }
            return -1;
        }

        public void GetNumber(string name)
        {
            string v;
            if (_data.TryGetValue(name, out v))
            {
                Console.WriteLine(v);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }
            else if (_data.ContainsKey(name))
            {
                _data[name] = number;
            }
            else
            {
                _data.Add(name, number);
                _dataCount++;
            }
        }
    }

}