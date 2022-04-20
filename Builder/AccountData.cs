using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Account
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public string Age { get; private set; }
        public string Marital_status { get; private set; }


        public static AccountBuilder With()
        {
            return new AccountBuilder();
        }

        public class AccountBuilder
        {
            private readonly Account _account = new Account();

            public AccountBuilder Name(string name)
            {
                _account.Name = name;
                return this;
            }

            public AccountBuilder Surname(string surname)
            {
                _account.Surname = surname;
                return this;
            }

            public AccountBuilder Gender(string gender)
            {
                _account.Gender = gender;
                return this;
            }

            public AccountBuilder Age(string age)
            {
                _account.Age = age;
                return this;
            }

            public AccountBuilder Marital_status(string marital_status)
            {
                _account.Marital_status = marital_status;
                return this;
            }

            public Account Build()
            {
                return _account;
            }
        }
    }
}
