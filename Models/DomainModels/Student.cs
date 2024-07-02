using StudentInformationProject.Models.Enums;

namespace StudentInformationProject.Models.DomainModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }
    }
}
