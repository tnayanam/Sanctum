﻿
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [Display(Name = "Amount Owed")]
        public decimal Amount { get; set; }
    }
}