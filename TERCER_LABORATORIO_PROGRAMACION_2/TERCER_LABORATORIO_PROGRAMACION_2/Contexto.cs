using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION2_3_PUNTOS_EN_JUEGO;

using Microsoft.EntityFrameworkCore;
public class Contexto : DbContext
{
    public DbSet<Datos> facultad { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-NFDMETJ\\SQLEXPRESS01;Database=lab3; Trusted_Connection = SSPI; MultipleActiveResultSets = true;");
    }
}