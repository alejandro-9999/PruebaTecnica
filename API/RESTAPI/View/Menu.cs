using System;
using RESTAPI.Control;
using RESTAPI.Model;
using System.Threading.Tasks;


namespace RESTAPI.View
{
    public class Menu
    {
        static async Task Main(string[] args)
        {
            var userController = new UserController();

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1 - Crear un usuario");
                Console.WriteLine("2 - Mostrar todos los usuarios");
                Console.Write("> ");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre de usuario:");
                        var userName = Console.ReadLine();

                        Console.WriteLine("Ingrese el correo electrónico:");
                        var email = Console.ReadLine();

                        Console.WriteLine("Ingrese la contraseña:");
                        var password = Console.ReadLine();

                        var newUser = new User(userName, email, password);

                        var createdUser = await userController.Create(newUser);

                        if (createdUser != null)
                        {
                            Console.WriteLine("Usuario creado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Error al crear el usuario.");
                        }

                        break;

                    case "2":
                        var users = await userController.getAllUsers();

                        if (users == null)
                        {
                            Console.WriteLine("Error al obtener los usuarios.");
                        }
                        else if (users.Count == 0)
                        {
                            Console.WriteLine("No hay usuarios registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Usuarios registrados:");
                            foreach (var user in users)
                            {
                                Console.WriteLine($"- Nombre de usuario: {user.userName}");
                                Console.WriteLine($"  Correo electrónico: {user.email}");
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
