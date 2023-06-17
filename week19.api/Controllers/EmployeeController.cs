using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using week19.application.Common.Interface;
using week19.application.DTO.EmployeeDTO;
using week19.domain.Entities;
using week19.infrastructure.Persistance;

namespace week19.api.Controllers;

[Route("api/employee")]
[ApiController]
public class EmployeeController : ControllerBase
{


    private readonly IEmployeeDetails _employeedb;
    public EmployeeController(IEmployeeDetails employee)
    {
        this._employeedb = employee;

    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GeAllEmployee()
    {
        var employee = await _employeedb.GetAllAsync();
        var employeeDTO = employee.Select(x => new EmployeeDTO
        {
            ID = x.ID,
            Name = x.Name,
            Address = x.Address,
            Phone = x.Phone,
            Salary = x.Salary,
        });

        return Ok(employeeDTO);
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public async Task<IActionResult> DeleteEmployeeAsync(Guid id)
    {
        var employee = await _employeedb.DeleteAsync(id);
        if (employee == null)
        {
            return BadRequest();
        }
        var employeeDTO = new EmployeeDTO
        {
            ID = employee.ID,
            Name = employee.Name,
            Address = employee.Address,
            Phone = employee.Phone,
            Salary = employee.Salary,
        };
        return Ok(employeeDTO);
    }

    [HttpPost("add-employee")]

    public async Task<IActionResult> AddEmployee(AddEmployeeDTO addEmployeeDto)
    {
        var employee = new Employee()
        {
            Name = addEmployeeDto.Name,
            Address = addEmployeeDto.Address,
            Phone = addEmployeeDto.Phone,
            Salary = addEmployeeDto.Salary,
        };

        await _employeedb.AddAsync(employee);

        var employeDto = new EmployeeDTO()
        {
            ID = employee.ID,
            Name = employee.Name,
            Address = employee.Address,
            Phone = employee.Phone,
            Salary = employee.Salary,
        };

        return Ok(employeDto);
    }

    [HttpPut]
    [Route("{id:guid}")]
    public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] Guid id, [FromBody] EmployeeDTO employeeDTO)
    {
        var employee = new Employee()
        {
            Name = employeeDTO.Name,
            Address = employeeDTO.Address,
            Phone = employeeDTO.Phone,
            Salary = employeeDTO.Salary,
        };

        employee = await _employeedb.UpdateAsync(id, employee);

        if (employee == null)
        {
            return NotFound();
        }

        var employeDTO = new EmployeeDTO()
        {
            ID = employee.ID,
            Name = employee.Name,
            Address = employee.Address,
            Phone = employee.Phone,
            Salary = employee.Salary,
        };
        return Ok(employeDTO);
    }

}