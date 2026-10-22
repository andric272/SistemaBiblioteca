using Biblioteca.Datos;
using Biblioteca.Entidades;

Console.WriteLine("========== LISTADO DE LIBROS ==========");

try
{
    LibroDatos libroDatos = new LibroDatos();
    List<Libro> libros = libroDatos.ListarLibros();

    foreach (Libro libro in libros)
    {
        Console.WriteLine($"Código: {libro.IdLibro}");
        Console.WriteLine($"Título: {libro.Titulo}");
        Console.WriteLine($"Autor: {libro.Autor}");
        Console.WriteLine($"Precio: {libro.Precio:0.00} Bs");
        Console.WriteLine($"Stock: {libro.Stock}");
        Console.WriteLine("---------------------------------------");
    }

    Console.WriteLine($"Total de libros: {libros.Count}");
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrió un error:");
    Console.WriteLine(ex.Message);
}

Console.ReadLine();