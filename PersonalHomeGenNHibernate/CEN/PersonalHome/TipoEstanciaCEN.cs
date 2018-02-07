

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
        public partial class TipoEstanciaCEN
        {
        private ITipoEstanciaCAD _ITipoEstanciaCAD;

        public TipoEstanciaCEN(ITipoEstanciaCAD _ITipoEstanciaCAD)
        {
                this._ITipoEstanciaCAD = _ITipoEstanciaCAD;
        }

        public int Crear (String p_nombre, String p_descripcion, String p_imagen)
        {
                TipoEstanciaEN tipoEstanciaEN = null;
                int oid;

                //Initialized TipoEstanciaEN
                tipoEstanciaEN = new TipoEstanciaEN ();
                tipoEstanciaEN.Nombre = p_nombre;
                tipoEstanciaEN.Descripcion = p_descripcion;
                tipoEstanciaEN.Imagen = p_imagen;
                //Call to TipoEstanciaCAD

                oid = _ITipoEstanciaCAD.Crear (tipoEstanciaEN);
                return oid;
        }

        public void Modificar (int p_TipoEstancia_OID, String p_nombre, String p_descripcion, String p_imagen)
        {
                TipoEstanciaEN tipoEstanciaEN = null;

                //Initialized TipoEstanciaEN
                tipoEstanciaEN = new TipoEstanciaEN ();
                tipoEstanciaEN.IdTipoEstancia = p_TipoEstancia_OID;
                tipoEstanciaEN.Nombre = p_nombre;
                tipoEstanciaEN.Descripcion = p_descripcion;
                tipoEstanciaEN.Imagen = p_imagen;
                //Call to TipoEstanciaCAD

                _ITipoEstanciaCAD.Modificar (tipoEstanciaEN);
        }

        public void Eliminar (int idTipoEstancia)
        {
                _ITipoEstanciaCAD.Eliminar (
                        idTipoEstancia

                        );
        }

        public TipoEstanciaEN DamePorID (int idTipoEstancia)
        {
                TipoEstanciaEN tipoEstanciaEN = null;

                tipoEstanciaEN = _ITipoEstanciaCAD.DamePorID (
                        idTipoEstancia

                        );
                return tipoEstanciaEN;
        }

        public System.Collections.Generic.IList<TipoEstanciaEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<TipoEstanciaEN> list = null;

                list = _ITipoEstanciaCAD.DameTodos (first, size);
                return list;
        }
        public void AsignarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                //Call to TipoEstanciaCAD

                _ITipoEstanciaCAD.AsignarFamiliaPack (p_TipoEstancia_OID, p_familiaPack_OIDs);
        }
        public void QuitarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                //Call to TipoEstanciaCAD

                _ITipoEstanciaCAD.QuitarFamiliaPack (p_TipoEstancia_OID, p_familiaPack_OIDs);
        }
        public void AsignarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                //Call to TipoEstanciaCAD

                _ITipoEstanciaCAD.AsignarEstancia (p_TipoEstancia_OID, p_estancia_OIDs);
        }
        public void QuitarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                //Call to TipoEstanciaCAD

                _ITipoEstanciaCAD.QuitarEstancia (p_TipoEstancia_OID, p_estancia_OIDs);
        }
        }
}
