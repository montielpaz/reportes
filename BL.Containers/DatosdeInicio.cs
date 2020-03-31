using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Containers
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "largo";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "mediano";
            contexto.Categorias.Add(categoria2);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Refijerante";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Termico";
            contexto.Tipos.Add(tipo2);

            var cliente1 = new Cliente();
            cliente1.Nombre = "Carlos Zuniga";
            cliente1.Telefono = "98763412";
            cliente1.Correo = "steve_123@gmail.com";
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "Jason Rodriguez";
            cliente2.Telefono = "9343412";
            cliente2.Correo = "tonys_13@gmail.com";
            contexto.Clientes.Add(cliente2);


            base.Seed(contexto);
        }
    }
}
