using System.ComponentModel;

namespace TurismoEmpresa;

class Program
{
    static string[] excursiones = ["Torres del Paine", "Rio Imperial", "Cordillera de los Andes"];
    static string[] comidas = ["Pizza Familiar", "Asado Familiar", "Ensalada Andina"];
    static string[] alojamiento = ["Alojamiento 4 personas Casa A", "Alojamiento 4 personas Casa B", "Alojamiento 3 personas Casa B"];
    static string[] servicios = ["Excursión", "Comida", "Alojamiento"];

    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write($"Correo: ");
        string correoUsuario = Console.ReadLine()!;

        Console.Clear();
        Console.WriteLine($"Seleccione el servicio deseado:");
        MostrarArray(servicios);
        int servicioIndice = IntMinMax(1, servicios.Length);

        Console.Clear();
        switch (servicioIndice)
        {
            case 1:
                Console.WriteLine($"Seleccione una excursión:");
                MostrarArray(excursiones);
                int excursionIndice = IntMinMax(1, excursiones.Length);

                Console.WriteLine($"Excursión a {excursiones[excursionIndice - 1]} confirmada. Se le enviará un correo de confirmación a {correoUsuario}.");
                break;
            case 2:
                Console.WriteLine($"Seleccione una comida:");
                MostrarArray(comidas);
                int comidaIndice = IntMinMax(1, excursiones.Length);

                Console.WriteLine($"Comida pedida: {comidas[comidaIndice - 1]}. Se le enviará un correo de confirmación a {correoUsuario}.");
                break;
            case 3:
                Console.WriteLine($"Seleccione alojamiento:");
                MostrarArray(alojamiento);
                int alojamientoIndice = IntMinMax(1, excursiones.Length);

                Console.WriteLine($"Usted seleccionó {alojamiento[alojamientoIndice - 1]}. Se le enviará un correo de confirmación a {correoUsuario}.");
                break;
        }
        Console.ReadKey(true);
    }

    static void MostrarArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"[{i + 1}] {arr[i]}");
        }
    }

    static int IntMinMax(int min, int max)
    {
        bool numeroValido;
        int numero;

        do
        {
            numeroValido = int.TryParse(Console.ReadLine()!, out numero);
            if (numero < min || numero > max) numeroValido = false;
        } while (!numeroValido);

        return numero;
    }
}
