

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
        public partial class InmuebleCEN
        {
        private IInmuebleCAD _IInmuebleCAD;

        public InmuebleCEN(IInmuebleCAD _IInmuebleCAD)
        {
                this._IInmuebleCAD = _IInmuebleCAD;
        }

        public int Crear (String p_nombre, double p_superficie, int p_dormitorios, int p_aseos, double p_importeDesde, double p_iva, String p_imagen, String p_plano, bool p_recomendado)
        {
                InmuebleEN inmuebleEN = null;
                int oid;

                //Initialized InmuebleEN
                inmuebleEN = new InmuebleEN ();
                inmuebleEN.Nombre = p_nombre;
                inmuebleEN.Superficie = p_superficie;
                inmuebleEN.Dormitorios = p_dormitorios;
                inmuebleEN.Aseos = p_aseos;
                inmuebleEN.ImporteDesde = p_importeDesde;
                inmuebleEN.Iva = p_iva;
                inmuebleEN.Imagen = p_imagen;
                inmuebleEN.Plano = p_plano;
                inmuebleEN.Recomendado = p_recomendado;
                //Call to InmuebleCAD

                oid = _IInmuebleCAD.Crear (inmuebleEN);
                return oid;
        }

        public void Modificar (int p_Inmueble_OID, String p_nombre, double p_superficie, int p_dormitorios, int p_aseos, double p_importeDesde, double p_iva, String p_imagen, String p_plano, bool p_recomendado)
        {
                InmuebleEN inmuebleEN = null;

                //Initialized InmuebleEN
                inmuebleEN = new InmuebleEN ();
                inmuebleEN.IdInmueble = p_Inmueble_OID;
                inmuebleEN.Nombre = p_nombre;
                inmuebleEN.Superficie = p_superficie;
                inmuebleEN.Dormitorios = p_dormitorios;
                inmuebleEN.Aseos = p_aseos;
                inmuebleEN.ImporteDesde = p_importeDesde;
                inmuebleEN.Iva = p_iva;
                inmuebleEN.Imagen = p_imagen;
                inmuebleEN.Plano = p_plano;
                inmuebleEN.Recomendado = p_recomendado;
                //Call to InmuebleCAD

                _IInmuebleCAD.Modificar (inmuebleEN);
        }

        public void Eliminar (int idInmueble)
        {
                _IInmuebleCAD.Eliminar (
                        idInmueble

                        );
        }

        public InmuebleEN DamePorID (int idInmueble)
        {
                InmuebleEN inmuebleEN = null;

                inmuebleEN = _IInmuebleCAD.DamePorID (
                        idInmueble

                        );
                return inmuebleEN;
        }

        public System.Collections.Generic.IList<InmuebleEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<InmuebleEN> list = null;

                list = _IInmuebleCAD.DameTodos (first, size);
                return list;
        }
        public void AsignarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                //Call to InmuebleCAD

                _IInmuebleCAD.AsignarVista (p_Inmueble_OID, p_vista_OIDs);
        }
        public void QuitarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                //Call to InmuebleCAD

                _IInmuebleCAD.QuitarVista (p_Inmueble_OID, p_vista_OIDs);
        }
        }
}
