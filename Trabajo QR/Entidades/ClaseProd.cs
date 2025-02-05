using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_QR.Entidades
{
    public class ClaseProd
    {
        public int? IdProd { get; set; }
        public string? CodProd { get; set; }
        public string? TipoProd { get; set; }
        public string? MarcaProd { get; set; }
        public string? UbicacionProd { get; set; }
        public string? NomProd { get; set; }
        public int? GarantiaProd { get; set; }
        public double? PrecioProd { get; set; }
        public int? CantProd { get; set; }
        public void CrearProducto(ClaseProd Producto)
        {
            string sql = $"insert into productos(CodProd, TipoProd, MarcaProd, UbicacionProd, NomProd, GarantiaProd, PrecioProd, CantProd)" +
                $"values('{Producto.CodProd}', '{Producto.TipoProd}', '{Producto.MarcaProd}', '{Producto.UbicacionProd}', '{Producto.NomProd}', '{Producto.GarantiaProd}', '{Producto.PrecioProd}', '{Producto.CantProd}');";
            //Crear instancia para la coneccion con la otra clase y llamar
            var mysqlconection = new ConexionMySQL();
            mysqlconection.Insertar(sql);
        }
        public void Actualizar(ClaseProd Prod)
        {
            string sql = $"update productos set CantProd = {Prod.CantProd} Where IdProd = {Prod.IdProd};";
            var mysqlconection = new ConexionMySQL();
            mysqlconection.Modificar(sql);

        }
        public List<ClaseProd> ListaProductos()
        {
            string sql = $"select * from productos"; //Construir sentencias
            //llamado a la funcion select
            var conexionMysql = new ConexionMySQL(); //Instacia de clase
            conexionMysql.AbrirConexion(); //Aqui para abrir
            var data = conexionMysql.Select(sql); //Ejecutar select

            List<ClaseProd> productos = new List<ClaseProd>(); //Declaro lista
            while (data.Read()) //Recorrer los datos para transformar de memoria a objeto
            {
                //asiganar nuevos objetos
                var Prod = new ClaseProd();
                Prod.IdProd = Convert.ToInt32(data[0]); //Data[posicion columna]
                Prod.CodProd = data[1].ToString();
                Prod.TipoProd = data[2].ToString();
                Prod.MarcaProd = data[3].ToString();
                Prod.UbicacionProd = data[4].ToString();
                Prod.NomProd = data[5].ToString();
                Prod.GarantiaProd = Convert.ToInt32(data[6].ToString());
                Prod.PrecioProd = Convert.ToDouble(data[7].ToString());
                Prod.CantProd = Convert.ToInt32(data[8].ToString());

                productos.Add(Prod); //Añadir objeto a la lista
            }
            //Retornar la lista
            conexionMysql.CerrarConexion(); //Aqui usar las funciones de abrir y cerrar
            return productos;
        }
        public List<ClaseProd> BuscarEstu(ClaseProd prodtipo)
        {
            string sql = $"select * from productos where TipoProd = '{prodtipo.TipoProd}'"; //Construir sentencias
            //llamado a la funcion select
            var conexionMysql = new ConexionMySQL(); //Instacia de clase
            conexionMysql.AbrirConexion(); //Aqui para abrir
            var data1 = conexionMysql.Buscar(sql); //Ejecutar select

            List<ClaseProd> Productos = new List<ClaseProd>(); //Declaro lista

            while (data1.Read()) //Recorrer los datos para transformar de memoria a objeto
            {
                //asiganar nuevos objetos
                var Prod1 = new ClaseProd();
                Prod1.IdProd = Convert.ToInt32(data1[0]); //Data[posicion columna]
                Prod1.CodProd = data1[1].ToString();
                Prod1.TipoProd = data1[2].ToString();
                Prod1.MarcaProd = data1[3].ToString();
                Prod1.UbicacionProd = data1[4].ToString();
                Prod1.NomProd = data1[5].ToString();
                Prod1.GarantiaProd = Convert.ToInt32(data1[6]);
                Prod1.PrecioProd = Convert.ToDouble(data1[7]);
                Prod1.CantProd = Convert.ToInt32(data1[8]);
                Productos.Add(Prod1);
            }

            //Retornar la lista
            conexionMysql.CerrarConexion(); //Aqui usar las funciones de abrir y cerrar
            return Productos;
        }
    }
}
