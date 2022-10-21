using PreEntrega.Controllers;




UsuarioController usuarios = new UsuarioController();
ProductoController productos = new ProductoController();
VentaController ventas = new VentaController();
ProductoVentaController productosVenta = new ProductoVentaController();

//   PUNTO A 

Console.WriteLine("Punto A");
Console.WriteLine("----------------------");

usuarios.TraerUsuario("eperez");

Console.WriteLine("----------------------");

//   PUNTO B

Console.WriteLine("Punto B\n");
Console.WriteLine("----------------------");

productos.TraerProducto(1);

//   PUNTO C 

Console.WriteLine("PUNTO D\n");
Console.WriteLine("----------------------");

productosVenta.TraerProductosVendidos(1);


//   PUNTO D 

Console.WriteLine("PUNTO D\n");
Console.WriteLine("----------------------");

ventas.TraerVentas(1);

Console.WriteLine("----------------------");



//   PUNTO E 

Console.WriteLine("PUNTO D\n");
Console.WriteLine("----------------------");

usuarios.InicioDeSesion("eperez", "ContraseñaIncorrecta");

Console.WriteLine("----------------------");