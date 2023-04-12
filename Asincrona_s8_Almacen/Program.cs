using Asincrona_s8_Almacen.Models;
using Asincrona_s8_Almacen.DAO;

Console.WriteLine("                ---------------------------------------------------------------------       ");
Console.WriteLine("                              Bienvenido a almacenes roock          ");
Console.WriteLine("                ---------------------------------------------------------------------       ");

CrudProducto CrudProducto = new CrudProducto();
Productos Producto = new Productos();

bool comprobar = true;
while (comprobar)
{
    Console.WriteLine(" \n               Menu                     ");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("    1. Agregue sus Producto.           ");
    Console.WriteLine("    2. Actualizar sus Productos.      ");
    Console.WriteLine("    3. Eliminar sus Productos seleccionado.         ");
    Console.WriteLine("    4. Lista de sus Productos.      ");
    Console.WriteLine("    5. Salir.                          ");

    Console.Write("\n¿Que realizar hacer? = ");
    var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {
        case 1:
            int bucle = 1;
            while (bucle == 1)
            {
                Console.WriteLine("*Agregar Producto:");

                Console.WriteLine("*Nombre del Producto: ");
                Producto.Nombre = Console.ReadLine();
                Console.WriteLine("*Describa el Producto:");
                Producto.Descripcion = Console.ReadLine();
                Console.WriteLine("*Precio: ");
                Producto.Precio = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("*Cantidad de Productos en Stock: ");
                Producto.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------\n");
                CrudProducto.AgregarProductos(Producto);

                Console.WriteLine(" Producto a sido Ingresado Correctamente \n");

                Console.WriteLine("seleccione con un numero la accion que desea realizar: ");
                Console.WriteLine("   1. Continuar ingresando los         ");
                Console.WriteLine("      productos.                    ");
                Console.WriteLine("   2. Salir.                        ");
                Console.Write("- ¿Que desea realizar? ");
                bucle = Convert.ToInt32(Console.ReadLine());

            }
            break;

        case 2:
            int bucle1 = 1;
            while (bucle1 == 1)
            {
                Console.WriteLine("\n Actualizar el Producto\n");
                Console.Write("Ingrese el ID del Producto que desea actualizar: ");
                var ProductoIndividualU = CrudProducto.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));

                if (ProductoIndividualU == null)
                {
                    Console.WriteLine("\nEl producto que ingreso no existe");

                    Console.WriteLine("\nque desea realizar: ");
                    Console.WriteLine("   1. Continuar          ");
                    Console.WriteLine("   2. Salir              ");
                    Console.Write("- ¿Que desea hacer? ");
                    bucle1 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nRegistro a actualizar:");
                    Console.WriteLine("\n Id Cantidad. Producto Descripcion Precio ");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"  {ProductoIndividualU.Id}  {ProductoIndividualU.Stock}    {ProductoIndividualU.Nombre}   {ProductoIndividualU.Descripcion}    {ProductoIndividualU.Precio}  ");

                    Console.WriteLine("\nPara actualizar coloca:       ");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("   1. Nombre                    ");
                    Console.WriteLine("   2. Descripcion               ");
                    Console.WriteLine("   3. Precio                    ");
                    Console.WriteLine("   4. Stock                     ");
                    Console.WriteLine("-----------------------------------");
                    Console.Write("- ¿Que desea actualizar? ");
                    var Lector = Convert.ToInt32(Console.ReadLine());

                    switch (Lector)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese el nombre:");
                            ProductoIndividualU.Nombre = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine($"\nIngrese la descripcion: {ProductoIndividualU.Nombre}");
                            ProductoIndividualU.Descripcion = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine($"\nIngrese el precio: {ProductoIndividualU.Nombre}");
                            ProductoIndividualU.Precio = Convert.ToDecimal(Console.ReadLine());
                            break;

                        case 4:
                            Console.WriteLine($"\nIngrese la cantidad: {ProductoIndividualU.Nombre}");
                            ProductoIndividualU.Stock = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    CrudProducto.ActualizarProducto(ProductoIndividualU, Lector);
                    Console.WriteLine("\n *Actualizacion Correctamente");

                    Console.WriteLine("\n Coloque: ");
                    Console.WriteLine("   1. Continuar actualizando        ");
                    Console.WriteLine("      productos                     ");
                    Console.WriteLine("   2. Salir                         ");
                    Console.Write("- ¿Que desea hacer? ");
                    bucle1 = Convert.ToInt32(Console.ReadLine());

                }

            }
            break;

        case 3:

            int bucle2 = 1;
            while (bucle2 == 1)
            {
                Console.WriteLine("\n Eliminar Producto");
                Console.WriteLine("------------------------------------");
                Console.Write("Ingrese el ID del producto que desea eliminar: ");
                var ProductoIndividualD = CrudProducto.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));

                if (ProductoIndividualD == null)
                {
                    Console.WriteLine("\nEl producto no existe");

                    Console.WriteLine("\n seleccione un numero para relaizar la accion que desea: ");
                    Console.WriteLine("   1. Continuar          ");
                    Console.WriteLine("   2. Salir              ");
                    Console.Write("- ¿Que desea hacer? ");
                    bucle2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nRegistro a eliminar:");
                    Console.WriteLine("\n Id Cantidad. Producto Descripcion Precio ");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"  {ProductoIndividualD.Id}  {ProductoIndividualD.Stock}    {ProductoIndividualD.Nombre}   {ProductoIndividualD.Descripcion}    {ProductoIndividualD.Precio}  ");
                    Console.WriteLine("\n¿Desea eliminar este producto permanentemente?");
                    Console.WriteLine("  1. Si    ");
                    Console.WriteLine("  2. No    ");
                    Console.Write("   *Opcion: ");

                    var Lector = Convert.ToInt32(Console.ReadLine());

                    if (Lector == 1)
                    {
                        var Id = Convert.ToInt32(ProductoIndividualD.Id);
                        Console.WriteLine(CrudProducto.EliminarProducto(Id));

                    }
                    else
                    {
                        Console.WriteLine("\n Inicie nuevamente");

                    }
                    Console.WriteLine("\nseleccione un numero para realisar la accion que desea: ");
                    Console.WriteLine("   1. Continuar eliminando          ");
                    Console.WriteLine("      productos                     ");
                    Console.WriteLine("   2. Salir                         ");
                    Console.Write("*¿Que desea hacer? ");
                    bucle2 = Convert.ToInt32(Console.ReadLine());

                }


            }

            break;

        case 4:
            Console.WriteLine("\n\n Productos Registrados:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" Id Cantidad. Productos Descripcion Precio  ");
            Console.WriteLine("-------------------------------------------");


            var ListadoProductos = CrudProducto.ListarProductos();
            foreach (var iteracionProducto in ListadoProductos)
            {
                Console.WriteLine($"  {iteracionProducto.Id}  {iteracionProducto.Stock}    {iteracionProducto.Nombre}   {iteracionProducto.Descripcion}    {iteracionProducto.Precio}  ");

            }
            Console.Write("\n Pulse Enter: ");
            var cont = Console.ReadLine();


            break;

        case 5:

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("         Gracias por preferirnos como su tienda online          ");
            Console.WriteLine("-------------------------------------------------------------");

            comprobar = false;

            break;

        default:
            Console.WriteLine("La opcion ingresada es incorrecta");
            break;

    }
}





//AlmacenContext db = new AlmacenContext();
//Productos producto = new Productos();

//Console.WriteLine();

//Console.Write("Ingrese el nombre de el producto :");
//producto.Nombre = Console.ReadLine();
//Console.Write("Describa el producto :");
//producto.Descripcion = Console.ReadLine();
//Console.Write("Ingrese el precio que tendra el producto :");
//producto.Precio = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Ingrese la cantidad de productos de stock :");
//producto.Stock = Convert.ToInt32(Console.ReadLine());

//db.Productos.Add(producto);
//db.SaveChanges();

//Console.WriteLine("   el producto ha sido registrado con exito   ");
//Console.WriteLine(" ...........................................");
//Console.WriteLine(" Id Cantidad. Productos Descripcion Precio ");
//Console.WriteLine(" ...........................................");

//Console.WriteLine();

//var ListaProductos = db.Productos.ToList();
//foreach (var product in ListaProductos)
//{

//    Console.WriteLine($"  {product.Id}  {product.Stock}    {product.Nombre} / {product.Descripcion} / ${product.Precio}");
//}


//Console.WriteLine("-------------------------------------------------------------------------");
//Console.WriteLine("         Gracias por preferirnos como su tienda online          ");
//Console.WriteLine("-------------------------------------------------------------------------");
