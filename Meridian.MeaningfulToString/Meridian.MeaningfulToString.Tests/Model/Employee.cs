using System.Collections.Generic;

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

        public IEnumerable<string> Emails
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