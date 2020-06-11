using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial_Aplicada2.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using PrimerParcial_Aplicada2.Models;

namespace PrimerParcial_Aplicada2.BLL.Tests
{
    [TestClass()]
    public class ArticuloBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulos articulos = new Articulos()
            {
                ArticuloId = 5,
                Descripcion = "Quinto Articulo",
                Existencia = 100,
                Costo = 50,
                ValorInventario = 5000,
                Fecha = DateTime.Now,


            };

            Assert.IsTrue(ArticuloBLL.Guardar(articulos));
        }


        [TestMethod()]
        public void ModificarTest()
        {

            Articulos articulos = new Articulos()
            {
                ArticuloId = 5,
                Descripcion = "Quinto Articulo",
                Existencia = 100,
                Costo = 10,
                ValorInventario = 1000,
                Fecha = DateTime.Now,


            };

            Assert.IsTrue(ArticuloBLL.Guardar(articulos));
        }



        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(ArticuloBLL.Buscar(5));
        }



        [TestMethod()]
        public void GetListTest()
        {
            ArticuloBLL BLL = new ArticuloBLL();
            Assert.IsNotNull(BLL.GetList(t => true));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(ArticuloBLL.Eliminar(5));
        }
    }
}