

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGenNHibernate.CAD.PersonalHome;

namespace PersonalHomeGenNHibernate.CEN.PersonalHome
{
        public partial class ProyectoCEN
        {
        private IProyectoCAD _IProyectoCAD;

        public ProyectoCEN(IProyectoCAD _IProyectoCAD)
        {
                this._IProyectoCAD = _IProyectoCAD;
        }

        public int Crear (String p_variables, int p_usuario)
        {
                ProyectoEN proyectoEN = null;
                int oid;

                //Initialized ProyectoEN
                proyectoEN = new ProyectoEN ();
                proyectoEN.Variables = p_variables;
                if (p_usuario != -1) {
                        proyectoEN.Usuario = new PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN ();
                        proyectoEN.Usuario.IdUsuario = p_usuario;
                }
                //Call to ProyectoCAD

                oid = _IProyectoCAD.Crear (proyectoEN);
                return oid;
        }

        public void Modificar (int p_Proyecto_OID, String p_variables)
        {
                ProyectoEN proyectoEN = null;

                //Initialized ProyectoEN
                proyectoEN = new ProyectoEN ();
                proyectoEN.IdProyecto = p_Proyecto_OID;
                proyectoEN.Variables = p_variables;
                //Call to ProyectoCAD

                _IProyectoCAD.Modificar (proyectoEN);
        }

        public void Eliminar (int idProyecto)
        {
                _IProyectoCAD.Eliminar (
                        idProyecto

                        );
        }

        public ProyectoEN DamePorID (int idProyecto)
        {
                ProyectoEN proyectoEN = null;

                proyectoEN = _IProyectoCAD.DamePorID (
                        idProyecto

                        );
                return proyectoEN;
        }

        public System.Collections.Generic.IList<ProyectoEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<ProyectoEN> list = null;

                list = _IProyectoCAD.DameTodos (first, size);
                return list;
        }
        }
}
