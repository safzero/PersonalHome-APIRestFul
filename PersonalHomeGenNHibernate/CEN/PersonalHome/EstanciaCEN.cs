

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
        public partial class EstanciaCEN
        {
        private IEstanciaCAD _IEstanciaCAD;

        public EstanciaCEN(IEstanciaCAD _IEstanciaCAD)
        {
                this._IEstanciaCAD = _IEstanciaCAD;
        }

        public int Crear (String p_nombre, String p_descripcion, String p_codigo, String p_plano)
        {
                EstanciaEN estanciaEN = null;
                int oid;

                //Initialized EstanciaEN
                estanciaEN = new EstanciaEN ();
                estanciaEN.Nombre = p_nombre;
                estanciaEN.Descripcion = p_descripcion;
                estanciaEN.Codigo = p_codigo;
                estanciaEN.Plano = p_plano;
                //Call to EstanciaCAD

                oid = _IEstanciaCAD.Crear (estanciaEN);
                return oid;
        }

        public void Modificar (int p_Estancia_OID, String p_nombre, String p_descripcion, String p_codigo, String p_plano)
        {
                EstanciaEN estanciaEN = null;

                //Initialized EstanciaEN
                estanciaEN = new EstanciaEN ();
                estanciaEN.IdEstancia = p_Estancia_OID;
                estanciaEN.Nombre = p_nombre;
                estanciaEN.Descripcion = p_descripcion;
                estanciaEN.Codigo = p_codigo;
                estanciaEN.Plano = p_plano;
                //Call to EstanciaCAD

                _IEstanciaCAD.Modificar (estanciaEN);
        }

        public void Eliminar (int idEstancia)
        {
                _IEstanciaCAD.Eliminar (
                        idEstancia

                        );
        }

        public EstanciaEN DamePorID (int idEstancia)
        {
                EstanciaEN estanciaEN = null;

                estanciaEN = _IEstanciaCAD.DamePorID (
                        idEstancia

                        );
                return estanciaEN;
        }

        public System.Collections.Generic.IList<EstanciaEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<EstanciaEN> list = null;

                list = _IEstanciaCAD.DameTodas (first, size);
                return list;
        }
        public void AsignarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                //Call to EstanciaCAD

                _IEstanciaCAD.AsignarTipoEstancia (p_Estancia_OID, p_tipoEstancia_OIDs);
        }
        public void QuitarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                //Call to EstanciaCAD

                _IEstanciaCAD.QuitarTipoEstancia (p_Estancia_OID, p_tipoEstancia_OIDs);
        }
        public void AsignarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                //Call to EstanciaCAD

                _IEstanciaCAD.AsignarVista (p_Estancia_OID, p_vista_OIDs);
        }
        public void QuitarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                //Call to EstanciaCAD

                _IEstanciaCAD.QuitarVista (p_Estancia_OID, p_vista_OIDs);
        }
        }
}
