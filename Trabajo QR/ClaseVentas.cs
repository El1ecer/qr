using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_QR.Entidades;

namespace Trabajo_QR
{
    public class ClaseVentas
    {
        public int IdVenta { get; set; }
        public string? EstadoVen {  get; set; }
        public int IdPro {  get; set; }
        public string? IdCli { get; set; }
        public int CantVen {  get; set; }
        public double ValorTotalVen { get; set; }
        public void CrearVenta(ClaseVentas ven)
        {
            string sql = $"insert into ventas (IdPro, EstadoVen, IdCli, CantVen, ValorTotalVen) values ('{ven.IdPro}', '{ven.EstadoVen}', '{ven.IdCli}','{ven.CantVen}', '{ven.ValorTotalVen}');";
            var conexion = new ConexionMySQL();
            conexion.Insertar(sql);
        }
        public void ActualizarVen(ClaseVentas ediven)
        {
            string sql = $"update ventas set EstadoVen = '{ediven.EstadoVen}' Where IdVenta = '{ediven.IdVenta}';";
            var mysqlconection = new ConexionMySQL();
            mysqlconection.Modificar(sql);

        }
        public List<ClaseVentas> ListaVentas()
        {
            string sql = $"select * from ventas"; //Construir sentencias
            //llamado a la funcion select
            var conexionMysql = new ConexionMySQL(); //Instacia de clase
            conexionMysql.AbrirConexion(); //Aqui para abrir
            var data = conexionMysql.Select(sql); //Ejecutar select

            List<ClaseVentas> TotalVentas = new List<ClaseVentas>(); //Declaro lista
            while (data.Read()) //Recorrer los datos para transformar de memoria a objeto
            {
                //asiganar nuevos objetos
                var Ven = new ClaseVentas();
                Ven.IdVenta = Convert.ToInt32(data[0]); //Data[posicion columna]
                Ven.EstadoVen = data[1].ToString();
                Ven.IdPro = Convert.ToInt32(data[2]);
                Ven.IdCli = data[3].ToString();
                Ven.CantVen = Convert.ToInt32(data[4]);
                Ven.ValorTotalVen = Math.Round(Convert.ToDouble(data[5]), 2);

                TotalVentas.Add(Ven); //Añadir objeto a la lista
            }
            //Retornar la lista
            conexionMysql.CerrarConexion(); //Aqui usar las funciones de abrir y cerrar
            return TotalVentas;
        }
        public List<ClaseVentas> BuscarVen(ClaseVentas venest)
        {
            string sql = $"select * from ventas where EstadoVen = '{venest.EstadoVen}'"; //Construir sentencias
            //llamado a la funcion select
            var conexionMysql = new ConexionMySQL(); //Instacia de clase
            conexionMysql.AbrirConexion(); //Aqui para abrir
            var data1 = conexionMysql.Buscar(sql); //Ejecutar select

            List<ClaseVentas> ventas = new List<ClaseVentas>(); //Declaro lista

            while (data1.Read()) //Recorrer los datos para transformar de memoria a objeto
            {
                //asiganar nuevos objetos
                var venta = new ClaseVentas();
                venta.IdVenta = Convert.ToInt32(data1[0]); //Data[posicion columna]
                venta.EstadoVen = data1[1].ToString();
                venta.IdPro = Convert.ToInt32(data1[2].ToString());
                venta.IdCli = data1[3].ToString();
                venta.CantVen = Convert.ToInt32(data1[4].ToString());
                venta.ValorTotalVen = Convert.ToDouble(data1[5].ToString());
                ventas.Add(venta);
            }

            //Retornar la lista
            conexionMysql.CerrarConexion(); //Aqui usar las funciones de abrir y cerrar
            return ventas;
        }
    }
}
