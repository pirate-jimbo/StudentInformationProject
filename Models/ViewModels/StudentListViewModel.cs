namespace StudentInformationProject.Models.ViewModels
{
    public class StudentListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public int ClassId { get; set; }
    }
}
