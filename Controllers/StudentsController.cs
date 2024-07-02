using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentInformationProject.Database;
using StudentInformationProject.Models.DomainModels;
using StudentInformationProject.Models.Dto;
using StudentInformationProject.Models.Enums;
using StudentInformationProject.Models.ViewModels;

namespace StudentInformationProject.Controllers
{
    public class StudentsController : Controller
    {
        public readonly ProjectDbContext _projectDbContext;
        public StudentsController(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var genderList = Enum.GetValues(typeof(GenderEnum))
                .OfType<Enum>().ToList()
                .Select(x => new SimplifiedGender()
                {
                    Id = Convert.ToInt32(x),
                    Value = x.ToString(),
                    IsChecked = false
                });

            var classList = _projectDbContext.Classes.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name,
            });

            var addStudentViewModel = new AddStudentViewModel()
            {
                StudentManageData = new ManageStudentDto(), 
                GenderList = genderList.ToList(),
                ClassList = classList.ToList()
            };

            return View(addStudentViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel addStudentViewModel)
        {
            var currentTime = DateTime.Now;
            return View();

            var studentToAdd = new Student()
            {
                Name = addStudentViewModel.StudentManageData.Name,
                Gender = addStudentViewModel.StudentManageData.Gender,
                //DateOfBirth = addStudentViewModel.StudentManageData.DateOfBirth ?? new DateOnly(),
                DateOfBirth = currentTime,
                CreatedDate = currentTime,
                ModificationDate = currentTime,
                ClassId = addStudentViewModel.StudentManageData.ClassId,
            };

            await _projectDbContext.Students.AddAsync(studentToAdd);
            await _projectDbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await _projectDbContext.Students.Select(x => new StudentListViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender.ToString(),
                DateOfBirth = x.DateOfBirth,
                CreatedDate = x.CreatedDate,
                ModificationDate = x.ModificationDate,
                ClassId = x.ClassId,
            }).ToListAsync();

            return View(students);
        }
    }
}
