using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport;

public class Position
{
    [Key]
    public int id { get; set; }
    public List<Employee> employees { get; set; }
    public string name { get; set; }
    public Position(string name)
    {
        this.name = name;
    }
    public override string ToString() => name;
}
