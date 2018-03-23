using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class Dbinitializer
    {
         public static void Initialize (SistemaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categoria.Any()) {
                return;


            }
            var categorias = new Categoria[]
            {

                new Categoria {Nombre ="Programacion", Descripcion ="Curso de Programacion" , Estado = true},
               new Categoria {Nombre ="Diseno Web", Descripcion ="Curso  Web" , Estado = true}
            };

            foreach (Categoria objeto  in categorias)
            {
                context.Categoria.Add(objeto);
            }
            context.SaveChanges();
        }
    }
}
