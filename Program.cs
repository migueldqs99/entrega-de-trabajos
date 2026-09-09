Console.WriteLine("Sistema de gestion - Registro de producto");
Console.WriteLine("=========================================");
Console.WriteLine();

// Nombre
Console.Write("Nombre del producto: ");
string nombre = Console.ReadLine() ?? "";

// Precio
Console.Write("Precio unitario: ");
string? textoPrecio = Console.ReadLine();
bool precioValido = double.TryParse(textoPrecio, out double precio);

// Cantidad
Console.Write("Cantidad en inventario: ");
string? textoCantidad = Console.ReadLine();
bool cantidadValida = int.TryParse(textoCantidad, out int cantidad);

Console.WriteLine();

// Validaciones
if (string.IsNullOrWhiteSpace(nombre))
{
    Console.WriteLine("Registro rechazado: el nombre no puede estar vacio.");
}
else if (!precioValido)
{
    Console.WriteLine("Registro rechazado: el precio ingresado no es un numero valido.");
}
else if (precio < 0)
{
    Console.WriteLine("Registro rechazado: el precio no puede ser negativo.");
}
else if (!cantidadValida)
{
    Console.WriteLine("Registro rechazado: la cantidad ingresada no es un numero entero valido.");
}
else if (cantidad > 1000)
{
    Console.WriteLine("Registro rechazado: la cantidad no puede superar las 1000 unidades.");
}
else
{
    Console.WriteLine("Producto registrado correctamente.");
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"Nombre   : {nombre}");
    Console.WriteLine($"Precio   : {precio}");
    Console.WriteLine($"Cantidad : {cantidad}");
}