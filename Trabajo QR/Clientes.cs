using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_QR.Entidades;

namespace Trabajo_QR
{
    public class Clientes
    {
        public string? CedCli { get; set; }
        public string? NomCli { get; set; }
        public string? ApeCli { get; set; }
        public string? TelfCli { get; set; }
        public string? DirectCli { get; set; }
        public void CrearCliente(Clientes cli)
        {
            string sql = $"insert into clientes (CedCli, NomCli,ApeCli,TelfCli ,DirectCli) values ('{cli.CedCli}', '{cli.NomCli}','{cli.ApeCli}','{cli.TelfCli}','{cli.DirectCli}');";
            var conexion = new ConexionMySQL();
            conexion.Insertar(sql);
        }
        public List<Clientes> ListaClientes()
        {
            string sql = $"select * from clientes"; //Construir sentencias
            //llamado a la funcion select
            var conexionMysql = new ConexionMySQL(); //Instacia de clase
            conexionMysql.AbrirConexion(); //Aqui para abrir
            var data = conexionMysql.Select(sql); //Ejecutar select

            List<Clientes> clientes = new List<Clientes>(); //Declaro lista
            while (data.Read()) //Recorrer los datos para transformar de memoria a objeto
            {
                //asiganar nuevos objetos
                var Cli = new Clientes(); //Data[posicion columna]
                Cli.CedCli = data[0].ToString();
                Cli.NomCli = data[1].ToString();
                Cli.ApeCli = data[2].ToString();
                Cli.TelfCli = data[3].ToString();
                Cli.DirectCli = data[4].ToString();

                clientes.Add(Cli); //Añadir objeto a la lista
            }
            //Retornar la lista
            conexionMysql.CerrarConexion(); //Aqui usar las funciones de abrir y cerrar
            return clientes;
        }
        public List<Clientes> BuscarCli(Clientes cedcli)
        {
            string sql = $"select * from clientes where CedCli = '{cedcli.CedCli}'"; //Construir sentencias
            //llamado a la funcion select
            var conexionMysql = new ConexionMySQL(); //Instacia de clase
            conexionMysql.AbrirConexion(); //Aqui para abrir
            var data1 = conexionMysql.Buscar(sql); //Ejecutar select

            List<Clientes> client = new List<Clientes>(); //Declaro lista

            while (data1.Read()) //Recorrer los datos para transformar de memoria a objeto
            {
                //asiganar nuevos objetos
                var client1 = new Clientes();
                client1.CedCli = data1[0].ToString();
                client1.NomCli = data1[1].ToString();
                client1.ApeCli = data1[2].ToString();
                client1.TelfCli = data1[3].ToString();
                client1.DirectCli = data1[4].ToString();
                client.Add(client1);
            }

            //Retornar la lista
            conexionMysql.CerrarConexion(); //Aqui usar las funciones de abrir y cerrar
            return client;
        }
    }
}
