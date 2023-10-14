using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WEB_LAB1.Models;

public partial class Product
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Назва товару - це обовязкове поле.")]
    [MaxLength(50, ErrorMessage = "Максимальна довжина назви товару є 50 символів.")]
    [DisplayName("Назва товару")]
    public string ProductName { get; set; }
    [Required(ErrorMessage = "Назва товару - це обовязкове поле.")]
    [MaxLength(50, ErrorMessage = "Максимальна довжина назви товару є 50 символів.")]
    [DisplayName("Опис товару")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Ціна товару - це обовязкове поле.")]
    [DisplayName("Ціна")]
    public int Price { get; set; }
    [Required(ErrorMessage = "Посилання - це обовязкове поле.")]
    [DisplayName("Посилання")]
    public string Link { get; set; }
}
