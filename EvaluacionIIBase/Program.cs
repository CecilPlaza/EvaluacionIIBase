using LibreriaEvaluacion.DAL;
using LibreriaEvaluacion.DTO;

const string nombreAlumno = "Wachimingo";

while (Menu(nombreAlumno))
{
    Console.ReadKey(); // pausa, solicitar la entrada de una tecla
}


static bool Menu(string CecilVaras)
{ 
    bool continuar = true;

    Console.Clear(); // Limpia la pantalla
    Console.Title = $"Evaluación II: {CecilVaras}";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("================");
    Console.WriteLine("1) Listar préstamos");
    Console.WriteLine("2) Agregar préstamo");
    Console.WriteLine("3) Actualizar préstamo");
    Console.WriteLine("4) Eliminar préstamo");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");

    string opcion = Console.ReadLine().Trim(); // " 1 " => "1"

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Listado de préstamos registrados");
            opcionListar();
            // ToDo: Lógica GUI de listado
            break;
        case "2":
            Console.WriteLine("Insertar un nuevo préstamo");
            opcionInsertar();
            // ToDo: Lógica GUI de inserción
            break;
        case "3":
            Console.WriteLine("Actualizar un préstamo existente");
            opcionActualizar();
            // ToDo: Lógica GUI de actualización
            break;
        case "4":
            Console.WriteLine("Eliminar un préstamo existente");
            opcionEliminar();
            // ToDo: Lógica GUI de eliminación
            break;
        case "0":
            Console.WriteLine("Saliendo del programa ...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    return continuar;
}

// ToDo: lógica de GUI

static bool opcionListar();
    try
    {
    Console.WriteLine("");
    }
    catch(Exception ex) 
    {
        
    }
static bool opcionInsertar();
PrestamoDAL prestamoDAL = new PrestamoDAL();
try
{
    Console.WriteLine("Ingrese ID: ");
    int id = int.Parse(Console.ReadLine().Trim());
    Console.WriteLine("Ingrese el Monto:");
    int monto = int.Parse(Console.ReadLine().Trim());

    PrestamoDTO nuevoPrestamo = new PrestamoDTO()
    { Id = id, Monto = monto };

    bool insertar = prestamoDAL.Insertar(nuevoPrestamo);

    if (insertar)
    {
        Console.WriteLine($"Se ha insertado monto total de {nuevoPrestamo.Monto} correctamente");
    }
    else
    {

        Console.WriteLine($"Hubo un error al agregar el monto de {nuevoPrestamo.Monto}");
    }
 }catch (Exception ex)
{
    Console.WriteLine($"Por favor ingrese valor valido para el monto");
}

