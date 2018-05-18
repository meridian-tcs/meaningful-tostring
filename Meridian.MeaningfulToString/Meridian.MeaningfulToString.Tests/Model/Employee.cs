namespace Meridian.MeaningfulToString.Tests.Model
{
    public class Employee : MeaningfulBase
    {
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public Employee Manager
        {
            get;
            set;
        }
    }
}