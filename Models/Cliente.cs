using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clientes.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
    [Display(Name = "Apellido")]
    public string Apellido { get; set; } = string.Empty;

    [Required(ErrorMessage = "El documento de identidad es obligatorio.")]
    [StringLength(20, ErrorMessage = "El documento no puede exceder los 20 caracteres.")]
    [Display(Name = "Documento de Identidad (DNI/Cédula)")]
    public string DocumentoIdentidad { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
    [StringLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres.")]
    [Display(Name = "Correo Electrónico")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    [Phone(ErrorMessage = "El número telefónico no es válido.")]
    [StringLength(20, ErrorMessage = "El teléfono no puede exceder los 20 caracteres.")]
    [Display(Name = "Teléfono")]
    public string Telefono { get; set; } = string.Empty;

    [Required(ErrorMessage = "La dirección es obligatoria.")]
    [StringLength(150, ErrorMessage = "La dirección no puede exceder los 150 caracteres.")]
    [Display(Name = "Dirección")]
    public string Direccion { get; set; } = string.Empty;

    [Required(ErrorMessage = "La ciudad es obligatoria.")]
    [StringLength(50, ErrorMessage = "La ciudad no puede exceder los 50 caracteres.")]
    [Display(Name = "Ciudad")]
    public string Ciudad { get; set; } = string.Empty;

    [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
    [DataType(DataType.Date)]
    [Display(Name = "Fecha de Nacimiento")]
    public DateTime FechaNacimiento { get; set; } = DateTime.Today.AddYears(-25);

    [Required(ErrorMessage = "La fecha de registro es obligatoria.")]
    [DataType(DataType.Date)]
    [Display(Name = "Fecha de Registro")]
    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El límite de crédito es obligatorio.")]
    [Range(0, 1000000, ErrorMessage = "El límite de crédito debe estar entre 0 y 1,000,000.")]
    [Column(TypeName = "decimal(18, 2)")]
    [Display(Name = "Límite de Crédito")]
    public decimal LimiteCredito { get; set; } = 0.00m;

    [Display(Name = "Activo")]
    public bool EstadoActivo { get; set; } = true;
}
