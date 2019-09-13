using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog (string dogName, string dogSex, string dogMother, string dogFather)
        {
            this._name = dogName;
            this._sex = dogSex;
            this._mother = dogMother;
            this._father = dogFather;
        }

        public Dog(string dogName, string dogSex)
        {
            this._name = dogName;
            this._sex = dogSex;
        }

        public void FathersName ()
        {
            if (this._father == null)
            {
                Console.WriteLine("The father of " + this._name + " is unknown");
            }
            else
            {
                Console.WriteLine("The father of " + this._name + " is " + this._father);
            }
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (otherDog._mother == this._mother)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
