﻿using Crm.BusinessLayer.Concrete;
using Crm.BusinessLayer.ValidationRules;
using Crm.DataAccessLayer.EntityFramework;
using Crm.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Controllers
{
    public class EmployeeController : Controller
    {
        //IOC

        EmployeeManager employeeManager = new EmployeeManager(new EFEmployeeDal());
        public IActionResult Index()
        {
            var values = employeeManager.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            ValidationResult result = validationRules.Validate(employee);
            if (result.IsValid)
            {
                employeeManager.TInsert(employee);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }
    }
}
