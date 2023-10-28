
using Microsoft.Win32.SafeHandles;
using PROGRAMACION2_3_PUNTOS_EN_JUEGO;

using (var context = new Contexto())
{
    Console.WriteLine("Lista de Estudiantes de la base de datos:");
    foreach (var datos in context.facultad.ToList())
    {
        Console.WriteLine($"ID: {datos.id}, Nombre: {datos.nombre}, Coordinador: {datos.coordinador}, Asignatura: {datos.asignaturas}, Docentes{datos.docentes}");
    }
}




//using (var context = new Contexto())
//{
//    Console.WriteLine("Ingrese el nombre para añadir a la base de datos:");
//    string nuevoNombre = Console.ReadLine();

//    var nuevoDato = new Datos()
//    {
//        nombre = nuevoNombre
//    };

//    context.Add(nuevoDato);
//    context.SaveChanges();

//    Console.WriteLine("Nombre añadido con éxito.");
//}







using (var context = new Contexto())
{
    Console.Write("Ingrese el ID para el que desea cambiar el nombre: ");
    int id = Convert.ToInt32(Console.ReadLine());

    var Nombre = context.facultad.FirstOrDefault(x => x.id == id);

    if (Nombre != null)
    {
        Console.WriteLine("Ingrese el nuevo nombre: ");
        Nombre.nombre = Console.ReadLine();
        context.SaveChanges();
        Console.WriteLine("Nombre actualizado con éxito.");
    }
    else
    {
        Console.WriteLine("ID INEXISTENTE, ASEGURATE DE INGRESAR EL ID CORRECTAMENTE.");
    }
}

