using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class Empleado
{
    private int Id { get; set; }
    public string Name { get; set; }
    public decimal Salario { get; set;}
    private decimal BonoP { get; set;}
    private bool Estado { get; set; }

    public Empleado(int Id, string Name, decimal Salario, decimal BonoP, bool Estado)
    {
        this.Id = Id;
        this.Name = Name;
        this.Salario = Salario;
        this.BonoP = BonoP;
        this.Estado = Estado;
    }
}
