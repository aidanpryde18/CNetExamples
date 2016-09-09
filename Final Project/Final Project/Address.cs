using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Address
    {
        //fields
        private string _name;       //The persons name
        private string _email;      //The persons e-mail address
        private string _phone;      //The persons phone #
        private string _comments;   //Comments for the person


        //Constructor
        public Address(string name, string email, string phone, string comments)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _comments = comments;
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Email property
        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }

        //Phone property
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        //Comments property
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
    }
}
