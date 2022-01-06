
using CrudExample.Entities;
using CrudExample.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CrudExample.Controllers

{
    [ApiController]
    [Route("[COntroller]")]
    public class DepartmentController : ControllerBase
    {
        IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data=await Task.Run(() => _departmentService.GetAllData());
            return data == null ? NotFound() : Ok(data);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var data = await Task.Run(() => _departmentService.GetById(Id));
            return data == null ? NotFound() : Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post(string Department)
        {
            var result=await Task.Run(() => _departmentService.InsertNewDepartment(Department));
            return result==null? BadRequest():Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Patch(int Id,string Department)
        {
            var result=await Task.Run(() => _departmentService.UpdateDepartmentById(Id, Department));
            return result==null? BadRequest():Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result= await Task.Run(()=>_departmentService.DeleteById(Id));
            return result==null? NotFound():Ok();
        }

    }
}
