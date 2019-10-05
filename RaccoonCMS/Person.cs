// This class defines a person, which can be an employee or a customer.

namespace RaccoonCMS
{
    class Person
    {
        private string _first_name, _last_name, _address, _city = "", _state = "", _zip = "", _phone = "";

        public Person()
        {
            _first_name = "";
            _last_name = "";
            _address = "";
            _city = "";
            _state = "";
            _zip = "";
            _phone = "";
        }
        public string First_Name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }
        public string Last_Name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Name
        {
            get { return _first_name + " " + _last_name; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
    partial class Customer : Person
    {
        private int _customer_id;
        private bool _mailing_list;

        public int CID
        {
            get { return _customer_id; }
            set { _customer_id = value; }
        }
        public bool MailingList
        {
            get { return _mailing_list;}
            set { _mailing_list = value; }
        }
    }
}
