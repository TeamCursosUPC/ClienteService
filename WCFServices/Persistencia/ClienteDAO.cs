using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{
    public class ClienteDAO
    {
        private string CadenaConexion = "Data Source=(local); Initial Catalog=BDLicoreria;Integrated Security=SSPI;";

        public Cliente Crear(Cliente clienteACrear)
        {
            Cliente clienteCreado = null;
            string sql = "INSERT INTO t_cliente VALUES (@idcliente, @nombre,@apellidoPaterno, @apellidoMaterno,@sexo,@dni,@correoElectronico, @contraseña,@celular,@direccion)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@idcliente", clienteACrear.IdCliente));
                    comando.Parameters.Add(new SqlParameter("@nombre", clienteACrear.Nombre));
                    comando.Parameters.Add(new SqlParameter("@apellidoPaterno", clienteACrear.ApellidoPaterno));
                    comando.Parameters.Add(new SqlParameter("@apellidoMaterno", clienteACrear.ApellidoMaterno));
                    comando.Parameters.Add(new SqlParameter("@sexo", clienteACrear.Sexo));
                    comando.Parameters.Add(new SqlParameter("@dni", clienteACrear.Dni));
                    comando.Parameters.Add(new SqlParameter("@correoElectronico", clienteACrear.CorreoElectronico));
                    comando.Parameters.Add(new SqlParameter("@contraseña", clienteACrear.Contraseña));
                    comando.Parameters.Add(new SqlParameter("@celular", clienteACrear.Celular));
                    comando.Parameters.Add(new SqlParameter("@direccion", clienteACrear.Direccion));
                    comando.ExecuteNonQuery();
                }
            }
            clienteCreado = Obtener(clienteACrear.CorreoElectronico);
            return clienteCreado;
        }

        public Cliente Obtener(string CorreoElectronico)
        {
            Cliente clienteEncontrado = null;
            string sql = "SELECT * FROM t_cliente WHERE correoElectronico=@correoElectronico;";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@correoElectronico", CorreoElectronico));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                //IdCliente = (int)resultado["idcliente"],
                                Nombre = (string)resultado["nombre"],
                                ApellidoPaterno = (string)resultado["apellidoPaterno"],
                                ApellidoMaterno = (string)resultado["apellidoMaterno"],
                                Sexo = (string)resultado["sexo"],
                                Dni = (int)resultado["dni"],
                                CorreoElectronico = (string)resultado["correoElectronico"],
                                Contraseña = (string)resultado["contraseña"],
                                Celular = (int)resultado["celular"],
                                Direccion = (string)resultado["direccion"]
                            };
                        }
                    }
                }
            }
            return clienteEncontrado;
        }

        public Cliente Modificar(Cliente clienteAModificar)
        {
            Cliente clienteModificado = null;
            string sql = "UPDATE t_cliente SET nombre=@nombre,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,sexo=@sexo,dni=@dni,contraseña=@contraseña,celular=@celular,direccion=@direccion WHERE correoElectronico=@correoElectronico";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nombre", clienteAModificar.Nombre));
                    comando.Parameters.Add(new SqlParameter("@apellidoPaterno", clienteAModificar.ApellidoPaterno));
                    comando.Parameters.Add(new SqlParameter("@apellidoMaterno", clienteAModificar.ApellidoMaterno));
                    comando.Parameters.Add(new SqlParameter("@sexo", clienteAModificar.Sexo));
                    comando.Parameters.Add(new SqlParameter("@dni", clienteAModificar.Dni));
                    comando.Parameters.Add(new SqlParameter("@contraseña", clienteAModificar.Contraseña));
                    comando.Parameters.Add(new SqlParameter("@correoElectronico", clienteAModificar.CorreoElectronico));
                    comando.Parameters.Add(new SqlParameter("@celular", clienteAModificar.Celular));
                    comando.Parameters.Add(new SqlParameter("@direccion", clienteAModificar.Direccion));
                    comando.ExecuteNonQuery();
                }
            }
            clienteModificado = Obtener(clienteAModificar.CorreoElectronico);
            return clienteModificado;
        }

        public void Eliminar(string CorreoElectronico)
        {
            string sql = "DELETE from t_cliente WHERE correoElectronico=@correoElectronico";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@correoElectronico", CorreoElectronico));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> Listar()
        {
            List<Cliente> clientesEncontrados = new List<Cliente>();
            Cliente clienteEncontrado = null;
            string sql = "SELECT * from t_cliente";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    { 
                        while (resultado.Read()){
                            clienteEncontrado = new Cliente()
                            {
                                Nombre = (string)resultado["nombre"],
                                ApellidoPaterno = (string)resultado["apellidoPaterno"],
                                ApellidoMaterno = (string)resultado["apellidoMaterno"],
                                Sexo = (string)resultado["sexo"],
                                Dni = (int)resultado["dni"],
                                CorreoElectronico = (string)resultado["correoElectronico"],
                                Contraseña = (string)resultado["contraseña"],
                                Celular = (int)resultado["celular"],
                                Direccion = (string)resultado["direccion"]
                            };
                            clientesEncontrados.Add(clienteEncontrado);
                        }
                    }
                }
            }
            return clientesEncontrados;
        }
    }
}