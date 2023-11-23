using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAPI
{
    class Usuario
    {

        // Atributos

        public long id_usuario { get; set; }
        public string dni_usuario { get; set; }
        public string? nombre_usuario { get; set; }
        public string? apellidos_usuario { get; set; }
        public string? tlf_usuario { get; set; }
        public string? email_usuario { get; set; }
        public string clave_usuario { get; set; }
        public bool? estaBloqueado_usuario { get; set; }
        public DateTime? fch_fin_bloqueo_usuario { get; set; }
        public DateTime? fch_alta_usuario { get; set; }
        public DateTime? fch_baja_usuario { get; set; }

        // FK
        public long AccesoId { get; set; }
        public Acceso? Acceso { get; set; }

        // Constructor

        public Usuario(string dni_usuario, string? nombre_usuario, string? apellidos_usuario, string? tlf_usuario, string? email_usuario, string clave_usuario, bool? estaBloqueado_usuario, DateTime? fch_fin_bloqueo_usuario, DateTime? fch_alta_usuario, DateTime? fch_baja_usuario, long accesoId, Acceso? acceso)
        {
            this.dni_usuario = dni_usuario;
            this.nombre_usuario = nombre_usuario;
            this.apellidos_usuario = apellidos_usuario;
            this.tlf_usuario = tlf_usuario;
            this.email_usuario = email_usuario;
            this.clave_usuario = clave_usuario;
            this.estaBloqueado_usuario = estaBloqueado_usuario;
            this.fch_fin_bloqueo_usuario = fch_fin_bloqueo_usuario;
            this.fch_alta_usuario = fch_alta_usuario;
            this.fch_baja_usuario = fch_baja_usuario;
            this.AccesoId = accesoId;
            this.Acceso = acceso;
        }

        // toString


        public void ToString()
        {
            string fchFinBloqueo = (fch_fin_bloqueo_usuario == null) ? "null" : fch_fin_bloqueo_usuario.ToString();
            string fchAlta = (fch_alta_usuario == null) ? "null" : fch_alta_usuario.ToString();
            string fchBaja = (fch_baja_usuario == null) ? "null" : fch_baja_usuario.ToString();
            Console.WriteLine("Usuario [Dni:{0}, Nombre:{1}, Apellidos:{2}, Telefono:{3}, Email:{4}, Clave:{5}, EstaBloqueado:{6}, Fecha Fin Bloqueo:{7}, Fecha Alta Usuario: {8}, Fecha Baja Usuario: {9}, Acceso: {10}]", dni_usuario
                                                                                                                                                                                                            , nombre_usuario
                                                                                                                                                                                                            , apellidos_usuario
                                                                                                                                                                                                            , tlf_usuario
                                                                                                                                                                                                            , email_usuario
                                                                                                                                                                                                            , clave_usuario
                                                                                                                                                                                                            , estaBloqueado_usuario
                                                                                                                                                                                                            , fchFinBloqueo
                                                                                                                                                                                                            , fchAlta
                                                                                                                                                                                                            , fchBaja
                                                                                                                                                                                                            , AccesoId);
        }
    }

    public class Acceso
    {
        // Atributos
        public long id_acceso { get; set; }
        public string? codigo_acceso { get; set; }
        public string? descripcion_acceso { get; set; }

        // Constructor

        public Acceso(string codigo_acceso, string descripcion_acceso)
        {
            this.codigo_acceso = codigo_acceso;
            this.descripcion_acceso = descripcion_acceso;
        }

        // ToString

        public void ToString()
        {
            Console.WriteLine("Acceso [Codigo:{0}, Descripcion:{1}]", codigo_acceso
                                                                    , descripcion_acceso);                                                                                                                                                                           
        }
    }
}
