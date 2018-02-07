

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
        public partial class VistaCEN
        {
        private IVistaCAD _IVistaCAD;

        public VistaCEN(IVistaCAD _IVistaCAD)
        {
                this._IVistaCAD = _IVistaCAD;
        }

        public int Crear (String p_nombre)
        {
                VistaEN vistaEN = null;
                int oid;

                //Initialized VistaEN
                vistaEN = new VistaEN ();
                vistaEN.Nombre = p_nombre;
                //Call to VistaCAD

                oid = _IVistaCAD.Crear (vistaEN);
                return oid;
        }

        public void Modificar (int p_Vista_OID, String p_nombre)
        {
                VistaEN vistaEN = null;

                //Initialized VistaEN
                vistaEN = new VistaEN ();
                vistaEN.IdVista = p_Vista_OID;
                vistaEN.Nombre = p_nombre;
                //Call to VistaCAD

                _IVistaCAD.Modificar (vistaEN);
        }

        public void Eliminar (int idVista)
        {
                _IVistaCAD.Eliminar (
                        idVista

                        );
        }

        public VistaEN DamePorID (int idVista)
        {
                VistaEN vistaEN = null;

                vistaEN = _IVistaCAD.DamePorID (
                        idVista

                        );
                return vistaEN;
        }

        public System.Collections.Generic.IList<VistaEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<VistaEN> list = null;

                list = _IVistaCAD.DameTodas (first, size);
                return list;
        }
        public void AsignarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                //Call to VistaCAD

                _IVistaCAD.AsignarEstancia (p_Vista_OID, p_estancia_OIDs);
        }
        public void QuitarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                //Call to VistaCAD

                _IVistaCAD.QuitarEstancia (p_Vista_OID, p_estancia_OIDs);
        }
        public void AsignarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs)
        {
                //Call to VistaCAD

                _IVistaCAD.AsignarInmueble (p_Vista_OID, p_inmueble_OIDs);
        }
        public void QuitarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs)
        {
                //Call to VistaCAD

                _IVistaCAD.QuitarInmueble (p_Vista_OID, p_inmueble_OIDs);
        }
        }
}
