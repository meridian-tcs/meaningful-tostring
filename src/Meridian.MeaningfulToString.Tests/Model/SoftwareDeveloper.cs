namespace Meridian.MeaningfulToString.Tests.Model
{
    public class SoftwareDeveloper : Employee
    {
        public enum SpecialityOption
        {
            CSharp,
            Java,
        }

        public SpecialityOption Speciality
        {
            get;
            set;
        }
    }
}
