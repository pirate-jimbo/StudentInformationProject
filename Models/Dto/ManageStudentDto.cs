using StudentInformationProject.Models.Enums;

namespace StudentInformationProject.Models.Dto
{
    public class ManageStudentDto
    {
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public int ClassId { get; set; }
    }
}
