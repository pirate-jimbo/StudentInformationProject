using Microsoft.AspNetCore.Mvc.Rendering;
using StudentInformationProject.Models.Dto;

namespace StudentInformationProject.Models.ViewModels
{
    public class AddStudentViewModel
    {
        public ManageStudentDto StudentManageData { get; set; }
        public List<SelectListItem> ClassList { get; set; }
        public List<SimplifiedGender> GenderList { get; set; }
    }
}
