using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Microsoft.ApplicationBlocks.ExceptionManagement
{
    /// <summary>
    /// Descripción breve de Excepciones.
    /// </summary>
    namespace AutorizacionTasaPlazoFijo
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError)
                : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner)
                : base(TextoError, inner)
            {
            }
            public BaseApplicationException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class UsuarioNoHabilitadoException : Exception
        {
            static string TextoError = "Usuario no habilitado para autorizar / rechazar este plazo fijo";
            public UsuarioNoHabilitadoException()
                : base(TextoError)
            {
            }
            public UsuarioNoHabilitadoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public UsuarioNoHabilitadoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
    namespace Usuario
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError)
                : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner)
                : base(TextoError, inner)
            {
            }
            public BaseApplicationException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class InexistenteException : Exception
        {
            static string TextoError = "Usuario inexistente";
            public InexistenteException () : base(TextoError)
            {
            }
            public InexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public InexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ImpersonalizadoException : Exception
        {
            static string TextoError = "No se pudo impersonalizar a ";
            public ImpersonalizadoException(string Usuario)
                : base(TextoError + Usuario)
            {
            }
            public ImpersonalizadoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public ImpersonalizadoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
    namespace SIGAL
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError)
                : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner)
                : base(TextoError, inner)
            {
            }
            public BaseApplicationException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class NroCertifInex : Microsoft.ApplicationBlocks.ExceptionManagement.SIGAL.BaseApplicationException
        {
            static string TextoError = "Plazo fijo inexistente en SIGAL de nro certificado:";
            private string nroCert;
            private string sucursal;
            public string NroCertificado
            {
                get
                {
                    return nroCert;
                }
            }
            public string Sucursal
            {
                get
                {
                    return sucursal;
                }
            }
            public NroCertifInex(string NroCertificado, string Suc)
                : base(TextoError + NroCertificado + " en la sucursal:" + Suc)
            {
                nroCert = NroCertificado;
                sucursal = Suc;
            }
            public NroCertifInex(Exception inner)
                : base(TextoError, inner)
            {
            }
            public NroCertifInex(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
    namespace MQ
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError)
                : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner)
                : base(TextoError, inner)
            {
            }
            public BaseApplicationException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class NroCertifInexException  : Microsoft.ApplicationBlocks.ExceptionManagement.MQ.BaseApplicationException
        {
            static string TextoError = "Plazo fijo inexistente de nro certificado:";
            private int nroCert;
            public int NroCertificado
            {
                get
                {
                    return nroCert;
                }
            }
            public NroCertifInexException(int NroCertificado)
                : base(TextoError + NroCertificado)
            {
                nroCert = NroCertificado;
            }
            public NroCertifInexException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public NroCertifInexException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class PfInexException  : Microsoft.ApplicationBlocks.ExceptionManagement.MQ.BaseApplicationException
        {
            static string TextoError = "Plazo fijo inexistente";
            public PfInexException(int IdPF, int NroCertif) : base(TextoError + " (IdPF:" + IdPF.ToString() + ", NroCertif:" + NroCertif.ToString() + ")")
            {
            }
            public PfInexException(int IdPF, string NroCertif)
                : base(TextoError + " (IdPF:" + IdPF.ToString() + ", NroCertif:" + NroCertif + ")")
            {
            }
            public PfInexException (Exception inner) : base(TextoError, inner)
            {
            }
            public PfInexException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace WF
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError)
                : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner)
                : base(TextoError, inner)
            {
            }
            public BaseApplicationException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class OpInexistenteException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Operacion inexistente (WF)";
            public OpInexistenteException () : base(TextoError)
            {
            }
            public OpInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public OpInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EventoInvalidoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Evento invalido (WF)";
            public EventoInvalidoException () : base(TextoError)
            {
            }
            public EventoInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EventoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EstadoHstInvalidoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Seleccion inválida de EstadoHst (WF)";
            public EstadoHstInvalidoException () : base(TextoError)
            {
            }
            public EstadoHstInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EstadoHstInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EstadoHstNoDefinidoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "EstadoHst no definido (WF)";
            public EstadoHstNoDefinidoException () : base(TextoError)
            {
            }
            public EstadoHstNoDefinidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EstadoHstNoDefinidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FlowInvalidoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Flow invalido (WF)";
            public FlowInvalidoException () : base(TextoError)
            {
            }
            public FlowInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public FlowInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CircuitoInvalidoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Circuito invalido (WF)";
            public CircuitoInvalidoException () : base(TextoError)
            {
            }
            public CircuitoInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public CircuitoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class NivSegInvalidoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Nivel de seguridad invalido (WF)";
            public NivSegInvalidoException () : base(TextoError)
            {
            }
            public NivSegInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public NivSegInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EventoSinSegException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Evento sin esquema de seguridad asociado (WF)";
            public EventoSinSegException () : base(TextoError)
            {
            }
            public EventoSinSegException (Exception inner) : base(TextoError, inner)
            {
            }
            public EventoSinSegException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class UsuarioNoCumpleSegException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Usuario no cumple con el esquema de seguridad del evento (WF)";
            public UsuarioNoCumpleSegException () : base(TextoError)
            {
            }
            public UsuarioNoCumpleSegException (Exception inner) : base(TextoError, inner)
            {
            }
            public UsuarioNoCumpleSegException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EventoIniMalConfiguradoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "El esquema de seguridad del evento inicial esta configurado de manera incorrecta.  Los eventos iniciales no deben requerir mas de una intervencion (WF)";
            public EventoIniMalConfiguradoException () : base(TextoError)
            {
            }
            public EventoIniMalConfiguradoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EventoIniMalConfiguradoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EstadoVirtualMalConfiguradoException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "No es posible encontrar el valor del estado (virtual) de destino, definido en el evento (WF)";
            public EstadoVirtualMalConfiguradoException () : base(TextoError)
            {
            }
            public EstadoVirtualMalConfiguradoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EstadoVirtualMalConfiguradoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CXOException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "Usuario no cumple con el esquema de control por oposicion (WF)";
            public CXOException () : base(TextoError)
            {
            }
            public CXOException (Exception inner) : base(TextoError, inner)
            {
            }
            public CXOException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FechaProcesoNoMatchException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "La fecha de proceso no coincide con la fecha de la base de datos";
            public FechaProcesoNoMatchException () : base(TextoError)
            {
            }
            public FechaProcesoNoMatchException (Exception inner) : base(TextoError, inner)
            {
            }
            public FechaProcesoNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FechaNoMatchException : Microsoft.ApplicationBlocks.ExceptionManagement.WF.BaseApplicationException
        {
            static string TextoError = "La fecha no coincide con la fecha de proceso";
            public FechaNoMatchException () : base(TextoError)
            {
            }
            public FechaNoMatchException (Exception inner) : base(TextoError, inner)
            {
            }
            public FechaNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace db
    {
        
        public class ConexionException : Exception
        {
            static string TextoError = "Problema de conexión a base de datos";
            public ConexionException () : base(TextoError)
            {
            }
            public ConexionException (Exception inner) : base(TextoError, inner)
            {
            }
            public ConexionException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EjecucionException : Exception
        {
            static string TextoError = "Problema en ejecución de script de SQL";
            public EjecucionException () : base(TextoError)
            {
            }
            public EjecucionException (Exception inner) : base(TextoError, inner)
            {
            }
            public EjecucionException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EjecucionConRollbackException : Exception
        {
            static string TextoError = "Problema en ejecución de script de SQL ( Se deshizo la operacion )";
            public EjecucionConRollbackException () : base(TextoError)
            {
            }
            public EjecucionConRollbackException (Exception inner) : base(TextoError, inner)
            {
            }
            public EjecucionConRollbackException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class RollbackException : Exception
        {
            static string TextoError = "Problema al tratar de deshacer la ejecución de un script de SQL";
            public RollbackException () : base(TextoError)
            {
            }
            public RollbackException (Exception inner) : base(TextoError, inner)
            {
            }
            public RollbackException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FlowEventoInvalidoException : Exception
        {
            static string TextoError = "Combinación Flow-Evento invalida";
            public FlowEventoInvalidoException () : base(TextoError)
            {
            }
            public FlowEventoInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public FlowEventoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TipoOpMepInexistenteException : Exception
        {
            static string TextoError = "Operatoria inexistente";
            public TipoOpMepInexistenteException () : base(TextoError)
            {
            }
            public TipoOpMepInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public TipoOpMepInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MepTransaccionalInsErrorException : Exception
        {
            static string TextoError = "No se pudo impactar la transferencia en el Sistema MepTransaccional.  Reporte el problema al personal responsable del mantenimiento de la aplicacion inmediatamente.  La operacion debera ingresarse al Sistema Mep Transaccional mediante el procedimiento de contingencia.  MepEnv N° ";
            public MepTransaccionalInsErrorException(int IdMep) : base(TextoError + IdMep + ".")
            {
            }
            public MepTransaccionalInsErrorException(int IdMep, Exception inner) : base(TextoError + IdMep + ".", inner)
            {
            }
            public MepTransaccionalInsErrorException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MepUpdPk_nro_movimientoErrorException : Exception
        {
            static string TextoError = "No se pudo registrar el N° de Movimiento de MepTransaccional en esta Aplicacion.  Reporte el problema al personal responsable del mantenimiento de la aplicacion inmediatamente.  El dato mencionado debera registrarse mediante el procedimiento de contingencia.  MepEnv N° ";
            public MepUpdPk_nro_movimientoErrorException(int IdMep) : base(TextoError + IdMep + ".")
            {
            }
            public MepUpdPk_nro_movimientoErrorException(int IdMep, Exception inner) : base(TextoError + IdMep + ".", inner)
            {
            }
            public MepUpdPk_nro_movimientoErrorException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MepUpdPk_nro_movimientoError2Exception : Exception
        {
            static string TextoError = "No se pudo registrar el N° de Movimiento de Mep Transaccional en esta Aplicacion porque el contenido de la transferencia ha sido modificado por otro usuario.  Reporte el problema al personal responsable del mantenimiento de la aplicacion inmediatamente.  El dato mencionado debera registrarse mediante el procedimiento de contingencia.  MepEnv N° ";
            public MepUpdPk_nro_movimientoError2Exception(int IdMep) : base(TextoError + IdMep)
            {
            }
            public MepUpdPk_nro_movimientoError2Exception (Exception inner) : base(TextoError, inner)
            {
            }
            public MepUpdPk_nro_movimientoError2Exception (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Mep
    {
        
        public class MepNoImplementadoException : Exception
        {
            static string TextoError = "Front-End Mep especifico: no implementado";
            public MepNoImplementadoException () : base(TextoError)
            {
            }
            public MepNoImplementadoException (Exception inner) : base(TextoError, inner)
            {
            }
            public MepNoImplementadoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ConstMepInvalidoException : Exception
        {
            static string TextoError = "Constructor de Front-End Mep invalido";
            public ConstMepInvalidoException () : base(TextoError)
            {
            }
            public ConstMepInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ConstMepInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MepInexistenteException : Exception
        {
            static string TextoError = "Transferencia Mep inexistente o inaccesible";
            public MepInexistenteException () : base(TextoError)
            {
            }
            public MepInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public MepInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MepExistenteException : Exception
        {
            static string TextoError = "Transferencia Mep existente";
            public MepExistenteException () : base(TextoError)
            {
            }
            public MepExistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public MepExistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ModoInvalidoException : Exception
        {
            static string TextoError = "Modo invalido";
            public ModoInvalidoException () : base(TextoError)
            {
            }
            public ModoInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ModoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class OpInvalidaEnModoException : Exception
        {
            static string TextoError = "Operacion invalida en Modo actual";
            public OpInvalidaEnModoException () : base(TextoError)
            {
            }
            public OpInvalidaEnModoException (Exception inner) : base(TextoError, inner)
            {
            }
            public OpInvalidaEnModoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MepInaccesibleException : Exception
        {
            static string TextoError = "Operacion inhabilitada para el usuario actual\r\nConsulte el Esquema de Seguridad de la transferencia";
            public MepInaccesibleException () : base(TextoError)
            {
            }
            public MepInaccesibleException (Exception inner) : base(TextoError, inner)
            {
            }
            public MepInaccesibleException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MepEnEstadoFinalException : Exception
        {
            static string TextoError = "Operacion inhabilitada.  La transferencia se encuentra en un 'estado final'";
            public MepEnEstadoFinalException () : base(TextoError)
            {
            }
            public MepEnEstadoFinalException (Exception inner) : base(TextoError, inner)
            {
            }
            public MepEnEstadoFinalException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        public class CircuitoIndetermEnDevolException : Exception
        {
            static string TextoError = "No es posible determinar el Sector al que devolver la transferencia";
            public CircuitoIndetermEnDevolException () : base(TextoError)
            {
            }
            public CircuitoIndetermEnDevolException (Exception inner) : base(TextoError, inner)
            {
            }
            public CircuitoIndetermEnDevolException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TipoOpMepInexistenteException : Exception
        {
            static string TextoError = "Operatoria inexistente";
            public TipoOpMepInexistenteException () : base(TextoError)
            {
            }
            public TipoOpMepInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public TipoOpMepInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FTipoOpMepInexistenteException : Exception
        {
            static string TextoError = "Familia de operatorias inexistente, reporte el incidente al Administrador Mep";
            public FTipoOpMepInexistenteException () : base(TextoError)
            {
            }
            public FTipoOpMepInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public FTipoOpMepInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FamiliaInexistenteException : Exception
        {
            static string TextoError = "Familia inexistente";
            public FamiliaInexistenteException () : base(TextoError)
            {
            }
            public FamiliaInexistenteException(string msg) : base(TextoError + ": " + msg)
            {
            }
            public FamiliaInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public FamiliaInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        namespace Validaciones
        {
            
            public class BaseApplicationException : Exception
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ImporteInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Importe invalido";
                public ImporteInvalidoException () : base(TextoError)
                {
                }
                public ImporteInvalidoException (Exception inner) : base(TextoError, inner)
                {
                }
                public ImporteInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SectorNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Sector no informado";
                public SectorNoInfoException () : base(TextoError)
                {
                }
                public SectorNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SectorNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ContactoApyNomNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Contacto no informado";
                public ContactoApyNomNoInfoException () : base(TextoError)
                {
                }
                public ContactoApyNomNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public ContactoApyNomNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ContactoViaNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Contacto Via no informada";
                public ContactoViaNoInfoException () : base(TextoError)
                {
                }
                public ContactoViaNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public ContactoViaNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ReadOnlyException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "modificacion inhabilitada";
                public ReadOnlyException(string Propiedad) : base(Propiedad + ": " + TextoError)
                {
                }
                public ReadOnlyException (Exception inner) : base(TextoError, inner)
                {
                }
                public ReadOnlyException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MonCtasOrdDestNoCoincException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Monedas de cuentas Ordenante y Destino no coincidentes";
                public MonCtasOrdDestNoCoincException () : base(TextoError)
                {
                }
                public MonCtasOrdDestNoCoincException (Exception inner) : base(TextoError, inner)
                {
                }
                public MonCtasOrdDestNoCoincException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ComentarioNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Comentario / motivo no informado";
                public ComentarioNoInfoException () : base(TextoError)
                {
                }
                public ComentarioNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public ComentarioNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class InstruccionNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Instruccion no informada";
                public InstruccionNoInfoException () : base(TextoError)
                {
                }
                public InstruccionNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public InstruccionNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ConceptoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Detalle no informado";
                public ConceptoNoInfoException () : base(TextoError)
                {
                }
                public ConceptoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public ConceptoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class IdMepMotivoRechNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Tipo de Rechazo no informado";
                public IdMepMotivoRechNoInfoException () : base(TextoError)
                {
                }
                public IdMepMotivoRechNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public IdMepMotivoRechNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBilleteNroNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "N° Solicitud Billetes no informado";
                public SolBilleteNroNoInfoException () : base(TextoError)
                {
                }
                public SolBilleteNroNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBilleteNroNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBilleteNombreToRNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nombre Transp. o Representante no informado";
                public SolBilleteNombreToRNoInfoException () : base(TextoError)
                {
                }
                public SolBilleteNombreToRNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBilleteNombreToRNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBilleteNroDocRNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "N° Doc. Representante no informado";
                public SolBilleteNroDocRNoInfoException () : base(TextoError)
                {
                }
                public SolBilleteNroDocRNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBilleteNroDocRNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NombreOrdenanteNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nombre ordenante no informado";
                public NombreOrdenanteNoInfoException () : base(TextoError)
                {
                }
                public NombreOrdenanteNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NombreOrdenanteNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class TitularPrestamoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Titular del prestamo no informado";
                public TitularPrestamoNoInfoException () : base(TextoError)
                {
                }
                public TitularPrestamoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public TitularPrestamoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroPrestamoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro prestamo no informado";
                public NroPrestamoNoInfoException () : base(TextoError)
                {
                }
                public NroPrestamoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroPrestamoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FecVtoPrestamoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Fecha vencimiento del prestamo no informada";
                public FecVtoPrestamoNoInfoException () : base(TextoError)
                {
                }
                public FecVtoPrestamoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public FecVtoPrestamoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroCtaBIDNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro Cuenta BID no informado";
                public NroCtaBIDNoInfoException () : base(TextoError)
                {
                }
                public NroCtaBIDNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroCtaBIDNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroBoletoConcertacionNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro de boleto de concertacion no informado";
                public NroBoletoConcertacionNoInfoException () : base(TextoError)
                {
                }
                public NroBoletoConcertacionNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroBoletoConcertacionNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Especie no informada";
                public EspecieNoInfoException () : base(TextoError)
                {
                }
                public EspecieNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CantidadAplicNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Cantidad Aplic no informada";
                public CantidadAplicNoInfoException () : base(TextoError)
                {
                }
                public CantidadAplicNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CantidadAplicNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class IdentifFormulaNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Identificacion formula no informada";
                public IdentifFormulaNoInfoException () : base(TextoError)
                {
                }
                public IdentifFormulaNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public IdentifFormulaNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class IdentifFormulaNoMatchException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Identificacion formula no coincide, debe ser ";
                public IdentifFormulaNoMatchException(string Correcta) : base(TextoError)
                {
                }
                public IdentifFormulaNoMatchException (Exception inner) : base(TextoError, inner)
                {
                }
                public IdentifFormulaNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CodReembolsoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Codigo de reembolso no informado";
                public CodReembolsoNoInfoException () : base(TextoError)
                {
                }
                public CodReembolsoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CodReembolsoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CodReembolsoNoMatchException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Codigo de reembolso incorrecto,";
                public CodReembolsoNoMatchException(string Descripcion) : base(TextoError + Descripcion)
                {
                }
                public CodReembolsoNoMatchException (Exception inner) : base(TextoError, inner)
                {
                }
                public CodReembolsoNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SucursalNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Sucursal no informada";
                public SucursalNoInfoException () : base(TextoError)
                {
                }
                public SucursalNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SucursalNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroExpedienteNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro Expediente no informado";
                public NroExpedienteNoInfoException () : base(TextoError)
                {
                }
                public NroExpedienteNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroExpedienteNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class AnioNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Año no informado";
                public AnioNoInfoException () : base(TextoError)
                {
                }
                public AnioNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public AnioNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class JuzgadoEmbargoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Juzgado Embargo no informado";
                public JuzgadoEmbargoNoInfoException () : base(TextoError)
                {
                }
                public JuzgadoEmbargoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public JuzgadoEmbargoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroOficioEmbargoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro oficio embargo no informado";
                public NroOficioEmbargoNoInfoException () : base(TextoError)
                {
                }
                public NroOficioEmbargoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroOficioEmbargoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroDocNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro documento no informado";
                public NroDocNoInfoException () : base(TextoError)
                {
                }
                public NroDocNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroDocNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class RazSocNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Razon social no informada";
                public RazSocNoInfoException () : base(TextoError)
                {
                }
                public RazSocNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public RazSocNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class DireccionSWIFTNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Direccion SWIFT no informada";
                public DireccionSWIFTNoInfoException () : base(TextoError)
                {
                }
                public DireccionSWIFTNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public DireccionSWIFTNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class DireccionSWIFTNoMatchException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Cadena 'US' no encontrada en la direccion SWIFT";
                public DireccionSWIFTNoMatchException () : base(TextoError)
                {
                }
                public DireccionSWIFTNoMatchException (Exception inner) : base(TextoError, inner)
                {
                }
                public DireccionSWIFTNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CantMonExtranjeraNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Cantidad moneda extranjera no informada";
                public CantMonExtranjeraNoInfoException () : base(TextoError)
                {
                }
                public CantMonExtranjeraNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CantMonExtranjeraNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CantMonExtranjeraNoMatchException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "No coincide con el importe";
                public CantMonExtranjeraNoMatchException () : base(TextoError)
                {
                }
                public CantMonExtranjeraNoMatchException (Exception inner) : base(TextoError, inner)
                {
                }
                public CantMonExtranjeraNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class TipoCambioNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Tipo de cambio no informado";
                public TipoCambioNoInfoException () : base(TextoError)
                {
                }
                public TipoCambioNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public TipoCambioNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CBUHaberesNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "CBU Haberes no informado";
                public CBUHaberesNoInfoException () : base(TextoError)
                {
                }
                public CBUHaberesNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CBUHaberesNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CUILHaberesNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "CUIL Haberes no informado";
                public CUILHaberesNoInfoException () : base(TextoError)
                {
                }
                public CUILHaberesNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CUILHaberesNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroOficioPagoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro oficio pago no informado";
                public NroOficioPagoNoInfoException () : base(TextoError)
                {
                }
                public NroOficioPagoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroOficioPagoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class JuzgadoPagoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Juzgado de pago no informado";
                public JuzgadoPagoNoInfoException () : base(TextoError)
                {
                }
                public JuzgadoPagoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public JuzgadoPagoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SecretariaNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Secretaria no informada";
                public SecretariaNoInfoException () : base(TextoError)
                {
                }
                public SecretariaNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SecretariaNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FueroNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Fuero no informado";
                public FueroNoInfoException () : base(TextoError)
                {
                }
                public FueroNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public FueroNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class AutosNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Autos no informados";
                public AutosNoInfoException () : base(TextoError)
                {
                }
                public AutosNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public AutosNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ExpedienteNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Expediente no informado";
                public ExpedienteNoInfoException () : base(TextoError)
                {
                }
                public ExpedienteNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public ExpedienteNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SucDestinoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Sucursal destino no informada";
                public SucDestinoNoInfoException () : base(TextoError)
                {
                }
                public SucDestinoNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SucDestinoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NroSecHostSiopelVTLNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Nro Sec Host Siopel VTL no informado";
                public NroSecHostSiopelVTLNoInfoException () : base(TextoError)
                {
                }
                public NroSecHostSiopelVTLNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NroSecHostSiopelVTLNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class LetraTituloDescrNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Letra titulo descr no informada";
                public LetraTituloDescrNoInfoException () : base(TextoError)
                {
                }
                public LetraTituloDescrNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public LetraTituloDescrNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CodTitCajValVTLNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "CodTitCajValVTL no informada";
                public CodTitCajValVTLNoInfoException () : base(TextoError)
                {
                }
                public CodTitCajValVTLNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CodTitCajValVTLNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FecVtoVTLNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Fecha vencimiento VTL no informada";
                public FecVtoVTLNoInfoException () : base(TextoError)
                {
                }
                public FecVtoVTLNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public FecVtoVTLNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CantMonExtranjeraCCENoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Cantidad moneda extranjera CCE no informada";
                public CantMonExtranjeraCCENoInfoException () : base(TextoError)
                {
                }
                public CantMonExtranjeraCCENoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CantMonExtranjeraCCENoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CantMonExtranjeraCCENoMatchException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "No coincide con el importe";
                public CantMonExtranjeraCCENoMatchException () : base(TextoError)
                {
                }
                public CantMonExtranjeraCCENoMatchException (Exception inner) : base(TextoError, inner)
                {
                }
                public CantMonExtranjeraCCENoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class TipoCambioCCENoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Tipo cambio CCE no informado";
                public TipoCambioCCENoInfoException () : base(TextoError)
                {
                }
                public TipoCambioCCENoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public TipoCambioCCENoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CBUDestinoCCENoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "CBU destino CCE no informado";
                public CBUDestinoCCENoInfoException () : base(TextoError)
                {
                }
                public CBUDestinoCCENoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CBUDestinoCCENoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CUITBenefCCENoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "CUIT beneficiario CCE no informado";
                public CUITBenefCCENoInfoException () : base(TextoError)
                {
                }
                public CUITBenefCCENoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CUITBenefCCENoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBilleteToRNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBilleteToR no informado";
                public SolBilleteToRNoInfoException () : base(TextoError)
                {
                }
                public SolBilleteToRNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBilleteToRNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBilleteTipoDocRNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBilleteTipoDocR no informado";
                public SolBilleteTipoDocRNoInfoException () : base(TextoError)
                {
                }
                public SolBilleteTipoDocRNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBilleteTipoDocRNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBilleteProvisionNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBilleteProvision no informado";
                public SolBilleteProvisionNoInfoException () : base(TextoError)
                {
                }
                public SolBilleteProvisionNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBilleteProvisionNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBillete1NoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBillete1 no informado";
                public SolBillete1NoInfoException () : base(TextoError)
                {
                }
                public SolBillete1NoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBillete1NoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBillete2NoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBillete2 no informado";
                public SolBillete2NoInfoException () : base(TextoError)
                {
                }
                public SolBillete2NoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBillete2NoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBillete3NoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBillete3 no informado";
                public SolBillete3NoInfoException () : base(TextoError)
                {
                }
                public SolBillete3NoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBillete3NoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBillete4NoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBillete4 no informado";
                public SolBillete4NoInfoException () : base(TextoError)
                {
                }
                public SolBillete4NoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBillete4NoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBillete5NoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBillete5 no informado";
                public SolBillete5NoInfoException () : base(TextoError)
                {
                }
                public SolBillete5NoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBillete5NoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBillete6NoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBillete6 no informado";
                public SolBillete6NoInfoException () : base(TextoError)
                {
                }
                public SolBillete6NoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBillete6NoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBillete7NoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "SolBillete7 no informado";
                public SolBillete7NoInfoException () : base(TextoError)
                {
                }
                public SolBillete7NoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBillete7NoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NumeroNegativoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "El numero debe ser mayor a cero en ";
                public NumeroNegativoException (string Propiedad) : base(TextoError + Propiedad)
                {
                }
                public NumeroNegativoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NumeroNegativoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MotivoRechDescrNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Motivo de Rechazo no informado";
                public MotivoRechDescrNoInfoException () : base(TextoError)
                {
                }
                public MotivoRechDescrNoInfoException (Exception inner) : base(TextoError, inner)
                {
                }
                public MotivoRechDescrNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ValorNoComboException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "opcion invalida";
                public ValorNoComboException (string Combo) : base(Combo + ": " + TextoError)
                {
                }
                public ValorNoComboException (Exception inner) : base(TextoError, inner)
                {
                }
                public ValorNoComboException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FechaInvalidaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "Fecha invalida";
                public FechaInvalidaException () : base(TextoError)
                {
                }
                public FechaInvalidaException (Exception inner) : base(TextoError, inner)
                {
                }
                public FechaInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SolBilleteInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "cantidad de billetes invalida";
                public SolBilleteInvalidoException (string SolBillete) : base(SolBillete + ": " + TextoError)
                {
                }
                public SolBilleteInvalidoException (Exception inner) : base(TextoError, inner)
                {
                }
                public SolBilleteInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class LenInvalidaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "longitud invalida";
                public LenInvalidaException (string Propiedad) : base(Propiedad + ": " + TextoError)
                {
                }
                public LenInvalidaException (Exception inner) : base(TextoError, inner)
                {
                }
                public LenInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class TipoNoCoincidenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "el tipo de la base de datos no coincide con la propiedad";
                public TipoNoCoincidenteException(string Propiedad) : base(Propiedad + ": " + TextoError)
                {
                }
                public TipoNoCoincidenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public TipoNoCoincidenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CBUNoCoincidenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "El CBU no coincide con la entidad ";
                public CBUNoCoincidenteException(string TipoCBU) : base(TextoError + TipoCBU)
                {
                }
                public CBUNoCoincidenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public CBUNoCoincidenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CUITNoCoincidenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "El CUIT no coincide con la entidad ";
                public CUITNoCoincidenteException(string TipoCBU) : base(TextoError + TipoCBU)
                {
                }
                public CUITNoCoincidenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public CUITNoCoincidenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CUITCoincidenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "El CUIT coincide con la entidad ";
                public CUITCoincidenteException(string TipoCBU) : base(TextoError + TipoCBU)
                {
                }
                public CUITCoincidenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public CUITCoincidenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class IdTCtaNoCoincidenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Mep.Validaciones.BaseApplicationException
            {
                static string TextoError = "El CBU no coincide con el tipo de cuenta, ";
                public IdTCtaNoCoincidenteException(string TCta) : base(TextoError + TCta)
                {
                }
                public IdTCtaNoCoincidenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public IdTCtaNoCoincidenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
        }
    }
    namespace Validaciones
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError) : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
            {
            }
            public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CierreCambioNoEncontradoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
        {
            static string TextoError = "Cierre de Cambio no encontrado";
            public CierreCambioNoEncontradoException(string IdMoneda, DateTime Fecha) : base(TextoError + ".  Moneda: '" + IdMoneda + "', Dia: " + Fecha.ToString("dd/MM/yyyy"))
            {
            }
            public CierreCambioNoEncontradoException (Exception inner) : base(TextoError, inner)
            {
            }
            public CierreCambioNoEncontradoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class AjusteEnPrecancNoHabilitadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
        {
            static string TextoError = "Ajuste de tasa y/o plazo no habilitado en pfs precancelables";
            public AjusteEnPrecancNoHabilitadoException () : base(TextoError)
            {
            }
            public AjusteEnPrecancNoHabilitadoException (Exception inner) : base(TextoError, inner)
            {
            }
            public AjusteEnPrecancNoHabilitadoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TramoPrecancFueraDeRangoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
        {
            static string TextoError = "La duración de algún tramo se superpone con el tramo siguiente";
            public TramoPrecancFueraDeRangoException () : base(TextoError)
            {
            }
            public TramoPrecancFueraDeRangoException (Exception inner) : base(TextoError, inner)
            {
            }
            public TramoPrecancFueraDeRangoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TramoPrecancTasaFueraDeRangoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
        {
            static string TextoError = "Las tasas deben ser mayores a 0 e iguales o mayores a la del tramo anterior";
            public TramoPrecancTasaFueraDeRangoException () : base(TextoError)
            {
            }
            public TramoPrecancTasaFueraDeRangoException (Exception inner) : base(TextoError, inner)
            {
            }
            public TramoPrecancTasaFueraDeRangoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TramoPrecancNoEncontradoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
        {
            static string TextoError = "Definición de tramo no encontrada";
            public TramoPrecancNoEncontradoException () : base(TextoError)
            {
            }
            public TramoPrecancNoEncontradoException (Exception inner) : base(TextoError, inner)
            {
            }
            public TramoPrecancNoEncontradoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PrecioNoEncontradoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
        {
            static string TextoError = "Precio no encontrado";
            public PrecioNoEncontradoException(string DescrEspecie, DateTime Fecha) : base(TextoError + ".  Especie: '" + DescrEspecie + "', Dia: " + Fecha.ToString("dd/MM/yyyy"))
            {
            }
            public PrecioNoEncontradoException (Exception inner) : base(TextoError, inner)
            {
            }
            public PrecioNoEncontradoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PrecioNoEncontradoEnExcelException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
        {
            static string TextoError = "Precio no encontrado en planilla Excel: ";
            public PrecioNoEncontradoEnExcelException(string DescrEspecie) : base(TextoError + DescrEspecie)
            {
            }
            public PrecioNoEncontradoEnExcelException (Exception inner) : base(TextoError, inner)
            {
            }
            public PrecioNoEncontradoEnExcelException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ConexionInactivaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Conexión inactiva con ";
            public ConexionInactivaException(string Sistema) : base(TextoError + Sistema)
            {
            }
            public ConexionInactivaException (Exception inner) : base(TextoError, inner)
            {
            }
            public ConexionInactivaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ElementoInexistenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "inexistente";
            public ElementoInexistenteException(string Descripcion) : base(Descripcion + " " + TextoError)
            {
            }
            public ElementoInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public ElementoInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ElementoNoEncontradoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            private static string TextoError = "no encontrado";

            public ElementoNoEncontradoException(string descrProp)
                : base(descrProp + " " + TextoError)
            {
            }

            public ElementoNoEncontradoException(Exception inner)
                : base(TextoError, inner)
            {
            }

            public ElementoNoEncontradoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class AjustePrecisionException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "No se puede ajustar ";
            public AjustePrecisionException(double Numero, int LongitudIncluyendoSeparador) : base(TextoError + Numero + " a " + LongitudIncluyendoSeparador + " posiciones")
            {
            }
            public AjustePrecisionException (Exception inner) : base(TextoError, inner)
            {
            }
            public AjustePrecisionException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ValorInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "valor inválido";
            public ValorInvalidoException (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public ValorInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ValorInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ValorNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "sin informar";
            public ValorNoInfoException (string descrProp) : base(descrProp + " " + TextoError)
            {
            }
            public ValorNoInfoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ValorNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ValorDesconocidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "desconocido";
            public ValorDesconocidoException (string descrProp) : base(descrProp + " " + TextoError)
            {
            }
            public ValorDesconocidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ValorDesconocidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FormatoPlanillaIncorrectoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Formato planilla incorrecto";
            public FormatoPlanillaIncorrectoException()
                : base(TextoError)
            {
            }
            public FormatoPlanillaIncorrectoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public FormatoPlanillaIncorrectoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class CanalIndeterminableException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "No se puede determinar el canal al que pertenece el ";
            public CanalIndeterminableException(string descrProp) : base(TextoError + " " + descrProp)
            {
            }
            public CanalIndeterminableException (Exception inner) : base(TextoError, inner)
            {
            }
            public CanalIndeterminableException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PerfilIndeterminableException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "No se puede determinar el perfil del ";
            public PerfilIndeterminableException(string descrProp) : base(TextoError + " " + descrProp)
            {
            }
            public PerfilIndeterminableException (Exception inner) : base(TextoError, inner)
            {
            }
            public PerfilIndeterminableException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class RolDesconocidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Rol desconocido: ";
            public RolDesconocidoException(string descrProp)
                : base(TextoError + " " + descrProp)
            {
            }
            public RolDesconocidoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public RolDesconocidoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class MultiploDeException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            private static string TextoError = " debe ser múltiplo de ";
            public MultiploDeException(string multiplo, string descrProp) : base(multiplo + TextoError + descrProp)
            {
            }
            public MultiploDeException (Exception inner) : base(TextoError, inner)
            {
            }
            public MultiploDeException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ReadOnlyException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "modificación inhabilitada";
            public ReadOnlyException (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public ReadOnlyException (Exception inner) : base(TextoError, inner)
            {
            }
            public ReadOnlyException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ValorNoMatchException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "no coincide, debe ser";
            public ValorNoMatchException(string descrProp, string descrPropMatch) : base(descrProp + " " + TextoError + " " + descrPropMatch)
            {
            }
            public ValorNoMatchException (Exception inner) : base(TextoError, inner)
            {
            }
            public ValorNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ValorNegativoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "debe ser mayor a cero";
            public ValorNegativoException (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public ValorNegativoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ValorNegativoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ValorNoNumericoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "debe ser numerico";
            public ValorNoNumericoException (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public ValorNoNumericoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ValorNoNumericoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ValorNoComboException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "opción inválida";
            public ValorNoComboException (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public ValorNoComboException (Exception inner) : base(TextoError, inner)
            {
            }
            public ValorNoComboException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class OpcionInvalidaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Opción inválida";
            public OpcionInvalidaException () : base(TextoError)
            {
            }
            public OpcionInvalidaException(string Descr) : base(TextoError + ": " + Descr)
            {
            }
            public OpcionInvalidaException (Exception inner) : base(TextoError, inner)
            {
            }
            public OpcionInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class LenInvalidaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "longitud inválida";
            public LenInvalidaException (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public LenInvalidaException (Exception inner) : base(TextoError, inner)
            {
            }
            public LenInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TipoNoCoincidenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "el tipo de la base de datos no coincide con la propiedad";
            public TipoNoCoincidenteException (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public TipoNoCoincidenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public TipoNoCoincidenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class NoEsMultiploDe24Exception  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "debe ser multiplo de 24";
            public NoEsMultiploDe24Exception (string descrProp) : base(descrProp + ": " + TextoError)
            {
            }
            public NoEsMultiploDe24Exception (Exception inner) : base(TextoError, inner)
            {
            }
            public NoEsMultiploDe24Exception (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ListaDeExcepcionesException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Lista de errores: ";
            private List<System.Exception> listaE;
            public ListaDeExcepcionesException(List<System.Exception> l) : base(TextoError)
            {
                listaE = l;
            }
            public List<System.Exception> ListaE
            {
                get
                {
                    return listaE;
                }
            }
        }

        namespace CashFlow
        {
            
            public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CtasMonConceptosException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.CashFlow.BaseApplicationException
            {
                static string TextoError = "Se modificaron los conceptos de ingresos y/o egresos de cuentas monetarias. Actualize parámetros del sistema";
                public CtasMonConceptosException () : base(TextoError)
                {
                }
                public CtasMonConceptosException (Exception inner) : base(TextoError, inner)
                {
                }
                public CtasMonConceptosException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
        }
        namespace Fechas
        {
            
            public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FechaNoHabilException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Fechas.BaseApplicationException
            {
                static string TextoError = "Según host la fecha no es un día hábil.";
                public FechaNoHabilException(string DescrProp) : base(DescrProp + ":" + TextoError)
                {
                }
                public FechaNoHabilException (Exception inner) : base(TextoError, inner)
                {
                }
                public FechaNoHabilException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FechaDsdCashFlowException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Fechas.BaseApplicationException
            {
                static string TextoError = "La fecha desde debe ser siempre la del día hábil anterior.";
                public FechaDsdCashFlowException(string DescrProp) : base(DescrProp + ":" + TextoError)
                {
                }
                public FechaDsdCashFlowException (Exception inner) : base(TextoError, inner)
                {
                }
                public FechaDsdCashFlowException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FechaFormatoNoValidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Fechas.BaseApplicationException
            {
                static string TextoError = "Formato incorrecto en: ";
                public FechaFormatoNoValidoException(string Nombre)
                    : base(TextoError + Nombre)
                {
                }
                public FechaFormatoNoValidoException(Exception inner)
                    : base(TextoError, inner)
                {
                }
                public FechaFormatoNoValidoException(SerializationInfo info, StreamingContext context)
                    : base(info, context)
                {
                }
            }
            
            public class FechaAñoInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Fechas.BaseApplicationException
            {
                static string TextoError = "Año incorrecto en";
                public FechaAñoInvalidoException(string Nombre)
                    : base(TextoError + Nombre)
                {
                }
                public FechaAñoInvalidoException(Exception inner)
                    : base(TextoError, inner)
                {
                }
                public FechaAñoInvalidoException(SerializationInfo info, StreamingContext context)
                    : base(info, context)
                {
                }
            }

            
            public class FechaMesInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Fechas.BaseApplicationException
            {
                static string TextoError = "Mes incorrecto en ";
                public FechaMesInvalidoException(string Nombre)
                    : base(TextoError + Nombre)
                {
                }
                public FechaMesInvalidoException(Exception inner)
                    : base(TextoError, inner)
                {
                }
                public FechaMesInvalidoException(SerializationInfo info, StreamingContext context)
                    : base(info, context)
                {
                }
            }
            
            public class FechaDiaInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Fechas.BaseApplicationException
            {
                static string TextoError = "Dia Incorrecto en ";
                public FechaDiaInvalidoException(string Nombre)
                    : base(TextoError + Nombre)
                {
                }
                public FechaDiaInvalidoException(Exception inner)
                    : base(TextoError, inner)
                {
                }
                public FechaDiaInvalidoException(SerializationInfo info, StreamingContext context)
                    : base(info, context)
                {
                }
            }
        }
        namespace FCIs
        {
            
            public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SociedadesIgualesException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "La sociedad gerente y la depositaria no pueden ser la misma.";
                public SociedadesIgualesException () : base(TextoError)
                {
                }
                public SociedadesIgualesException (Exception inner) : base(TextoError, inner)
                {
                }
                public SociedadesIgualesException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ConfirmacionException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "No se pudo confirmar porque falta calcular el valorCP de al menos un fondo";
                public ConfirmacionException () : base(TextoError)
                {
                }
                public ConfirmacionException (Exception inner) : base(TextoError, inner)
                {
                }
                public ConfirmacionException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EtapaCalculoConFCIsAsocException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "No se puede dar de baja una Etapa de Calculo que tenga FCIs vinculados.  Desvincule los FCIs y vuelva a intentar la baja.";
                public EtapaCalculoConFCIsAsocException () : base(TextoError)
                {
                }
                public EtapaCalculoConFCIsAsocException (Exception inner) : base(TextoError, inner)
                {
                }
                public EtapaCalculoConFCIsAsocException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class RevalyCalcCPsinSyRsPermitidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "No está permitido ejecutar el proceso de Revaluo de Cartera y calculo Valor CP sin informacion de Suscripciones y Rescates.";
                public RevalyCalcCPsinSyRsPermitidoException () : base(TextoError)
                {
                }
                public RevalyCalcCPsinSyRsPermitidoException (Exception inner) : base(TextoError, inner)
                {
                }
                public RevalyCalcCPsinSyRsPermitidoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EtapaCapturaConSubTipoEspeciesAsocException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "No se puede dar de baja una Etapa de Captura que tenga Subtipos de especies vinculadas.  Desvincule los Subtipos de especies y vuelva a intentar la baja.";
                public EtapaCapturaConSubTipoEspeciesAsocException () : base(TextoError)
                {
                }
                public EtapaCapturaConSubTipoEspeciesAsocException (Exception inner) : base(TextoError, inner)
                {
                }
                public EtapaCapturaConSubTipoEspeciesAsocException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CedFCIxlsRegistroException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "CedFCIxls.dll no está correctamente registrada.";
                public CedFCIxlsRegistroException () : base(TextoError)
                {
                }
                public CedFCIxlsRegistroException (Exception inner) : base(TextoError, inner)
                {
                }
                public CedFCIxlsRegistroException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CedFCIxlsProcesoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "Error al procesar planilla excel:";
                public CedFCIxlsProcesoException(string Errores) : base(TextoError + Errores)
                {
                }
                public CedFCIxlsProcesoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CedFCIxlsProcesoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CedFCIItfMensualNoFileException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "Error al procesar interfaz mensual:";
                public CedFCIItfMensualNoFileException(string Errores) : base(TextoError + Errores + ". Archivo inexistente.")
                {
                }
                public CedFCIItfMensualNoFileException (Exception inner) : base(TextoError, inner)
                {
                }
                public CedFCIItfMensualNoFileException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CedFCIItfSemanalCtaSinTagException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "Error al procesar interfaz semanal. La cuenta no está asociada a un tag:";
                public CedFCIItfSemanalCtaSinTagException(string Errores) : base(TextoError + Errores + ".")
                {
                }
                public CedFCIItfSemanalCtaSinTagException (Exception inner) : base(TextoError, inner)
                {
                }
                public CedFCIItfSemanalCtaSinTagException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CedFCINoSePuedeInformarException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "No se puede informar FCI Cartera en fondos que no sean de Clase";
                public CedFCINoSePuedeInformarException(string Errores) : base(TextoError + Errores)
                {
                }
                public CedFCINoSePuedeInformarException (Exception inner) : base(TextoError, inner)
                {
                }
                public CedFCINoSePuedeInformarException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CedFCISinInformarException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "FCI Cartera sin informar";
                public CedFCISinInformarException(string Errores) : base(TextoError + Errores)
                {
                }
                public CedFCISinInformarException (Exception inner) : base(TextoError, inner)
                {
                }
                public CedFCISinInformarException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CedFCICtasAsocAFondosDeClaseException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "No se admite que los fondos de Clase tengan cuentas asociadas. Primero elimine o reclasifique las cuentas y luego reintente la retipificación del fondo";
                public CedFCICtasAsocAFondosDeClaseException(string Errores) : base(TextoError + Errores)
                {
                }
                public CedFCICtasAsocAFondosDeClaseException (Exception inner) : base(TextoError, inner)
                {
                }
                public CedFCICtasAsocAFondosDeClaseException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class UNTipoCarteraConDependenciasException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "No se puede dar de baja un Fondo de Cartera sin antes dar de baja sus Fondos de Clase";
                public UNTipoCarteraConDependenciasException () : base(TextoError)
                {
                }
                public UNTipoCarteraConDependenciasException (Exception inner) : base(TextoError, inner)
                {
                }
                public UNTipoCarteraConDependenciasException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NoInformadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "El FCI no ha sido informado";
                public NoInformadoException () : base(TextoError)
                {
                }
                public NoInformadoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NoInformadoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ValorCPCalculadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "Existe un valor de cuotaparte calculado";
                public ValorCPCalculadoException () : base(TextoError)
                {
                }
                public ValorCPCalculadoException (Exception inner) : base(TextoError, inner)
                {
                }
                public ValorCPCalculadoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MonedaExtranjeraParaDiaSiguienteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "Los fondos que publican precio para el día siguiente sólo pueden ser de moneda local.";
                public MonedaExtranjeraParaDiaSiguienteException () : base(TextoError)
                {
                }
                public MonedaExtranjeraParaDiaSiguienteException (Exception inner) : base(TextoError, inner)
                {
                }
                public MonedaExtranjeraParaDiaSiguienteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class ValorCPdiferenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
            {
                static string TextoError = "Diferencia en valor de cuota calculado para el día de proceso con respecto al calculado el día anterior. El precio correcto es ";
                public ValorCPdiferenteException (string IdUN, decimal PrecioCorrecto, decimal PrecioIncorrecto) : base("FCI " + IdUN + ":" + TextoError + PrecioCorrecto + " y es distinto a " + PrecioIncorrecto)
                {
                }
                public ValorCPdiferenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public ValorCPdiferenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            namespace Proceso
            {
                
                public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.BaseApplicationException
                {
                    public BaseApplicationException(string TextoError) : base(TextoError)
                    {
                    }
                    public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                    {
                    }
                    public BaseApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class CapturaSyrDefinitivasException : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.FCIs.Proceso.BaseApplicationException
                {
                    static string TextoError = "No se pueden capturar suscripciones ni rescates cuando la fecha actual difiere en más de un día hábil con la de proceso.";
                    public CapturaSyrDefinitivasException () : base(TextoError)
                    {
                    }
                    public CapturaSyrDefinitivasException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public CapturaSyrDefinitivasException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
            }
        }
        namespace Operaciones
        {
            
            public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NoBalanceaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "La operación no balancea.  Verifique la Diferencia.";
                public NoBalanceaException () : base(TextoError)
                {
                }
                public NoBalanceaException (Exception inner) : base(TextoError, inner)
                {
                }
                public NoBalanceaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class DetalleNoIngresadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "La operación debe contener, al menos, dos minutas";
                public DetalleNoIngresadoException () : base(TextoError)
                {
                }
                public DetalleNoIngresadoException (Exception inner) : base(TextoError, inner)
                {
                }
                public DetalleNoIngresadoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MinutaAutomaticaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Opcion invalida en minuta automatica";
                public MinutaAutomaticaException () : base(TextoError)
                {
                }
                public MinutaAutomaticaException (Exception inner) : base(TextoError, inner)
                {
                }
                public MinutaAutomaticaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CierreCambioNoIngresadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Cierre de Cambio no ingresado";
                public CierreCambioNoIngresadoException () : base(TextoError)
                {
                }
                public CierreCambioNoIngresadoException (Exception inner) : base(TextoError, inner)
                {
                }
                public CierreCambioNoIngresadoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class UNincongruenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Hay, al menos, una minuta que referencia a una cuenta de otra unidad de negocio";
                public UNincongruenteException () : base(TextoError)
                {
                }
                public UNincongruenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public UNincongruenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class FechaincongruenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Hay, al menos, una minuta con un vencimiento establecido. Para modificar la fecha de la operación, dé de baja la minuta y depure.";
                public FechaincongruenteException () : base(TextoError)
                {
                }
                public FechaincongruenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public FechaincongruenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NoEnEstadoFinalException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Existe al menos una operación que no se encuentra en estado final.";
                public NoEnEstadoFinalException () : base(TextoError)
                {
                }
                public NoEnEstadoFinalException (Exception inner) : base(TextoError, inner)
                {
                }
                public NoEnEstadoFinalException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class PreciosNoEnEstadoFinalException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Existe al menos un precio que no se encuentra en estado final.";
                public PreciosNoEnEstadoFinalException () : base(TextoError)
                {
                }
                public PreciosNoEnEstadoFinalException (Exception inner) : base(TextoError, inner)
                {
                }
                public PreciosNoEnEstadoFinalException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class TasaCAyCCENoEnEstadoFinalException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Existe al menos una tasa que no se encuentra en estado final.";
                public TasaCAyCCENoEnEstadoFinalException () : base(TextoError)
                {
                }
                public TasaCAyCCENoEnEstadoFinalException (Exception inner) : base(TextoError, inner)
                {
                }
                public TasaCAyCCENoEnEstadoFinalException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CierreDeCambioNoEnEstadoFinalException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
            {
                static string TextoError = "Existe al menos un cierre de cambio que no se encuentra en estado final.";
                public CierreDeCambioNoEnEstadoFinalException () : base(TextoError)
                {
                }
                public CierreDeCambioNoEnEstadoFinalException (Exception inner) : base(TextoError, inner)
                {
                }
                public CierreDeCambioNoEnEstadoFinalException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            namespace Minutas
            {
                
                public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.BaseApplicationException
                {
                    public BaseApplicationException(string TextoError) : base(TextoError)
                    {
                    }
                    public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                    {
                    }
                    public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class UNincongruenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "Unidad de Negocio incongruente.  No se incorporará la minuta.";
                    public UNincongruenteException () : base(TextoError)
                    {
                    }
                    public UNincongruenteException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public UNincongruenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class IndiceFueraDeRangoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "Unidad de Negocio incongruente.  No se incorporará la minuta.";
                    public IndiceFueraDeRangoException () : base(TextoError)
                    {
                    }
                    public IndiceFueraDeRangoException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public IndiceFueraDeRangoException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class ConvinacionTipoMovProductoInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "Tipo de movimiento, en Producto, inválido";
                    public ConvinacionTipoMovProductoInvalidoException () : base(TextoError)
                    {
                    }
                    public ConvinacionTipoMovProductoInvalidoException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public ConvinacionTipoMovProductoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class CantidadCPRescException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "No se pueden rescatar mas cuotapartes de las suscriptas";
                    public CantidadCPRescException () : base(TextoError)
                    {
                    }
                    public CantidadCPRescException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public CantidadCPRescException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class ImporteAPagarNegativoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "Las deducciones deben ser menor al capital más los intereses";
                    public ImporteAPagarNegativoException () : base(TextoError)
                    {
                    }
                    public ImporteAPagarNegativoException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public ImporteAPagarNegativoException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class VentaTitulosException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "La cantidad(VN) disponible no es suficiente: ";
                    public VentaTitulosException(decimal Cantidad) : base(TextoError + Cantidad)
                    {
                    }
                    public VentaTitulosException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public VentaTitulosException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class DifCamEnCtaPesosException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "Los movimientos de diferencia de cambio no se pueden aplicar a rubros en pesos";
                    public DifCamEnCtaPesosException () : base(TextoError)
                    {
                    }
                    public DifCamEnCtaPesosException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public DifCamEnCtaPesosException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
                
                public class DifCamTipoMovInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Operaciones.Minutas.BaseApplicationException
                {
                    static string TextoError = "Tipo de movimiento invalido en operacion de Diferencia de Cambio";
                    public DifCamTipoMovInvalidoException () : base(TextoError)
                    {
                    }
                    public DifCamTipoMovInvalidoException (Exception inner) : base(TextoError, inner)
                    {
                    }
                    public DifCamTipoMovInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
                    {
                    }
                }
            }
        }
        namespace Cuentas
        {
            
            public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class DuplicadaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No se pudo dar de alta esa cuenta porque ya está cargada.";
                public DuplicadaException () : base(TextoError)
                {
                }
                public DuplicadaException (Exception inner) : base(TextoError, inner)
                {
                }
                public DuplicadaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            public class IdCuentaDuplicadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "El nuevo Id. de cuenta generaría valores duplicados";
                public IdCuentaDuplicadoException () : base(TextoError)
                {
                }
                public IdCuentaDuplicadoException (Exception inner) : base(TextoError, inner)
                {
                }
                public IdCuentaDuplicadoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class TasaDuplicadaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "Esa tasa ya existe en el sistema.";
                public TasaDuplicadaException () : base(TextoError)
                {
                }
                public TasaDuplicadaException (Exception inner) : base(TextoError, inner)
                {
                }
                public TasaDuplicadaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
        }
        namespace Especies
        {
            
            public class BaseApplicationException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CodigoCVException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "El código de CV debe tener cinco dígitos";
                public CodigoCVException () : base(TextoError)
                {
                }
                public CodigoCVException (Exception inner) : base(TextoError, inner)
                {
                }
                public CodigoCVException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class CodBCRAException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "El código de moneda de BCRA no está cargado en el sistema:";
                public CodBCRAException(string CodBCRA) : base(TextoError + CodBCRA)
                {
                }
                public CodBCRAException (Exception inner) : base(TextoError, inner)
                {
                }
                public CodBCRAException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieSinCotizacionFCIException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No hay precio ingresado/capturado para la especie de CódigoCV:";
                public EspecieSinCotizacionFCIException(string CodigoCV) : base(TextoError + CodigoCV)
                {
                }
                public EspecieSinCotizacionFCIException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieSinCotizacionFCIException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieSinCotizacionException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No hay último precio negociado en catálogo para la especie de CódigoCV:";
                public EspecieSinCotizacionException(string CodigoCV) : base(TextoError + CodigoCV)
                {
                }
                public EspecieSinCotizacionException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieSinCotizacionException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class TasaBadlarSinCotizacionException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No existe la tasa badlar para esa fecha en CU";
                public TasaBadlarSinCotizacionException () : base(TextoError)
                {
                }
                public TasaBadlarSinCotizacionException (Exception inner) : base(TextoError, inner)
                {
                }
                public TasaBadlarSinCotizacionException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieSinCroFechaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No se puede consultar a CedPM con fecha mayor a la de proceso";
                public EspecieSinCroFechaException () : base(TextoError)
                {
                }
                public EspecieSinCroFechaException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieSinCroFechaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieFechaConsultaPrecioException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No se puede consultar a CU un precio de especie con fecha distinta a la del día";
                public EspecieFechaConsultaPrecioException () : base(TextoError)
                {
                }
                public EspecieFechaConsultaPrecioException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieFechaConsultaPrecioException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MonedaSinCotizacionBNAException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No hay cotización para la moneda ";
                public MonedaSinCotizacionBNAException(string IdMoneda) : base(TextoError + IdMoneda)
                {
                }
                public MonedaSinCotizacionBNAException (Exception inner) : base(TextoError, inner)
                {
                }
                public MonedaSinCotizacionBNAException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MonedaNoContempladaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "El sistema no puede consultar precios de la moneda ";
                public MonedaNoContempladaException(string IdMoneda) : base(TextoError + IdMoneda)
                {
                }
                public MonedaNoContempladaException (Exception inner) : base(TextoError, inner)
                {
                }
                public MonedaNoContempladaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MercadoNoContempladoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No existe el mercado en el sistema: ";
                public MercadoNoContempladoException(string IdMercado) : base(TextoError + IdMercado)
                {
                }
                public MercadoNoContempladoException (Exception inner) : base(TextoError, inner)
                {
                }
                public MercadoNoContempladoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieEnCarteraException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "Especie actualmente en cartera de al menos un fondo";
                public EspecieEnCarteraException () : base(TextoError)
                {
                }
                public EspecieEnCarteraException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieEnCarteraException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieEnCarteraFondoDelDiaSiguienteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "Especie con precio en moneda extranjera no admitida en un fondo que publica valor de cuotaparte del día siguiente";
                public EspecieEnCarteraFondoDelDiaSiguienteException () : base(TextoError)
                {
                }
                public EspecieEnCarteraFondoDelDiaSiguienteException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieEnCarteraFondoDelDiaSiguienteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieYaExistenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "Esa especie ya existe en el sistema.";
                public EspecieYaExistenteException () : base(TextoError)
                {
                }
                public EspecieYaExistenteException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieYaExistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class EspecieYaExistenteCAFCIException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No se pudo dar de alta porque existe una especie con igual código CAFCI y tipo de código CAFCI.";
                public EspecieYaExistenteCAFCIException () : base(TextoError)
                {
                }
                public EspecieYaExistenteCAFCIException (Exception inner) : base(TextoError, inner)
                {
                }
                public EspecieYaExistenteCAFCIException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
        }
        namespace Comisiones
        {
            
            public class AccionXestadoInvalidaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "La acción que intenta realizar no corresponde al estado actual.";
                public AccionXestadoInvalidaException () : base(TextoError)
                {
                }
                public AccionXestadoInvalidaException (Exception inner) : base(TextoError, inner)
                {
                }
                public AccionXestadoInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }

            
            public class EstadoInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.Cuentas.BaseApplicationException
            {
                static string TextoError = "No es posible operar en el estado actual.";
                public EstadoInvalidoException () : base(TextoError)
                {
                }
                public EstadoInvalidoException (Exception inner) : base(TextoError, inner)
                {
                }
                public EstadoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
        }
    }
    namespace Sesion
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError) : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
            {
            }
            public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CrearException : Exception
        {
            static string TextoError = "No se puede crear una sesion de trabajo";
            public CrearException () : base(TextoError)
            {
            }
            public CrearException (Exception inner) : base(TextoError, inner)
            {
            }
            public CrearException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class AplicInvalidaException : Exception
        {
            static string TextoError = "Codigo de aplicación inválido";
            public AplicInvalidaException () : base(TextoError)
            {
            }
            public AplicInvalidaException (Exception inner) : base(TextoError, inner)
            {
            }
            public AplicInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ParametroInexistenteException : Exception
        {
            static string TextoError = "Parámetro AppConfig inexistente: ";
            public ParametroInexistenteException(string NombreParametro) : base(TextoError + NombreParametro)
            {
            }
            public ParametroInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public ParametroInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        namespace Usuario
        {
            
            public class NoHabilitadoException : Exception
            {
                static string TextoError = "Usuario no habilitado";
                public NoHabilitadoException () : base(TextoError)
                {
                }
                public NoHabilitadoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NoHabilitadoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class NoActivoException : Exception
            {
                static string TextoError = "Usuario no activo";
                public NoActivoException () : base(TextoError)
                {
                }
                public NoActivoException (Exception inner) : base(TextoError, inner)
                {
                }
                public NoActivoException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class DeBajaException : Exception
            {
                static string TextoError = "Usuario dado de baja";
                public DeBajaException () : base(TextoError)
                {
                }
                public DeBajaException (Exception inner) : base(TextoError, inner)
                {
                }
                public DeBajaException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }

        }
    }
    namespace Tablero
    {
        
        public class EstadoSectorInvalidoException : Exception
        {
            static string TextoError = "Combinación Estado-Sector inválida en armado de tablero";
            public EstadoSectorInvalidoException () : base(TextoError)
            {
            }
            public EstadoSectorInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EstadoSectorInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Replicador
    {
        
        public class ReplicadandoDatosException : Exception
        {
            static string TextoError = "Problema replicando datos";
            public ReplicadandoDatosException () : base(TextoError)
            {
            }
            public ReplicadandoDatosException(string msg) : base(TextoError + ": " + msg)
            {
            }
            public ReplicadandoDatosException (Exception inner) : base(TextoError, inner)
            {
            }
            public ReplicadandoDatosException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Archivo
    {
        
        public class ProcesarArchivoException : Exception
        {
            static string TextoError = "Problema procesando archivo";
            public ProcesarArchivoException () : base(TextoError)
            {
            }
            public ProcesarArchivoException(string msg) : base(TextoError + ": " + msg)
            {
            }
            public ProcesarArchivoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ProcesarArchivoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ArchivoInconsistenteException : Exception
        {
            static string TextoError = "Archivo inconsistente";
            public ArchivoInconsistenteException () : base(TextoError)
            {
            }
            public ArchivoInconsistenteException(string msg) : base(TextoError + ": " + msg)
            {
            }
            public ArchivoInconsistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public ArchivoInconsistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ArchivoInexistenteException : Exception
        {
            static string TextoError = "Archivo inexistente";
            public ArchivoInexistenteException () : base(TextoError)
            {
            }
            public ArchivoInexistenteException(string NombreArchivo) : base(TextoError + ": " + NombreArchivo)
            {
            }
            public ArchivoInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public ArchivoInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace XML
    {
        
        public class TransformacionException : Exception
        {
            static string TextoError = "Transformación fallida";
            public TransformacionException () : base(TextoError)
            {
            }
            public TransformacionException (Exception inner) : base(TextoError, inner)
            {
            }
            public TransformacionException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Colocaciones
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError) : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
            {
            }
            public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CapitalNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Capital no informado";
            public CapitalNoInfoException () : base(TextoError)
            {
            }
            public CapitalNoInfoException (Exception inner) : base(TextoError, inner)
            {
            }
            public CapitalNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TasaNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Tasa no informada";
            public TasaNoInfoException () : base(TextoError)
            {
            }
            public TasaNoInfoException (Exception inner) : base(TextoError, inner)
            {
            }
            public TasaNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PlazoNoInfoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Plazo no informado";
            public PlazoNoInfoException () : base(TextoError)
            {
            }
            public PlazoNoInfoException (Exception inner) : base(TextoError, inner)
            {
            }
            public PlazoNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class VtoNoHabilException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Vencimiento en día no habil";
            public VtoNoHabilException () : base(TextoError)
            {
            }
            public VtoNoHabilException (Exception inner) : base(TextoError, inner)
            {
            }
            public VtoNoHabilException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ColocRenovadaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Hay una colocación que ya ha sido renovada";
            public ColocRenovadaException () : base(TextoError)
            {
            }
            public ColocRenovadaException (Exception inner) : base(TextoError, inner)
            {
            }
            public ColocRenovadaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ColocCanceladaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Hay una colocación que ya ha sido cancelada";
            public ColocCanceladaException () : base(TextoError)
            {
            }
            public ColocCanceladaException (Exception inner) : base(TextoError, inner)
            {
            }
            public ColocCanceladaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ColocRenovIncorrectaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "No se puede renovar colocaciones no vencidas";
            public ColocRenovIncorrectaException () : base(TextoError)
            {
            }
            public ColocRenovIncorrectaException (Exception inner) : base(TextoError, inner)
            {
            }
            public ColocRenovIncorrectaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PFRenovadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Hay un plazo fijo que ya ha sido renovado";
            public PFRenovadoException () : base(TextoError)
            {
            }
            public PFRenovadoException (Exception inner) : base(TextoError, inner)
            {
            }
            public PFRenovadoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PFCanceladoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Hay un plazo fijo que ya ha sido cancelado";
            public PFCanceladoException () : base(TextoError)
            {
            }
            public PFCanceladoException (Exception inner) : base(TextoError, inner)
            {
            }
            public PFCanceladoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PFNoVencidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Hay un plazo fijo que no está vencido";
            public PFNoVencidoException () : base(TextoError)
            {
            }
            public PFNoVencidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public PFNoVencidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PFRenovIncorrectaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "No se puede renovar plazos fijos vigentes";
            public PFRenovIncorrectaException () : base(TextoError)
            {
            }
            public PFRenovIncorrectaException (Exception inner) : base(TextoError, inner)
            {
            }
            public PFRenovIncorrectaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ErrorPrecalculoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Colocaciones.BaseApplicationException
        {
            static string TextoError = "Error en precalculo de plazo fijo: ";
            public ErrorPrecalculoException(string precalcErr) : base(TextoError + precalcErr)
            {
            }
            public ErrorPrecalculoException (Exception inner) : base(TextoError, inner)
            {
            }
            public ErrorPrecalculoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Host
    {
        
        public class CantDiasInvalidaException : Exception
        {
            static string TextoError = "(HOST) Cantidad de días inválida";
            public CantDiasInvalidaException () : base(TextoError)
            {
            }
            public CantDiasInvalidaException (Exception inner) : base(TextoError, inner)
            {
            }
            public CantDiasInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class MonedaInvalidaException : Exception
        {
            static string TextoError = "Moneda Invalida: ";
            public MonedaInvalidaException(string a)
                : base(TextoError + a)
            {
            }
            public MonedaInvalidaException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public MonedaInvalidaException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class AutorizacionFinanciaraInvalidaException : Exception
        {
            static string TextoError = "No es posible realizar Autorizacion a Financiera: ";
            public AutorizacionFinanciaraInvalidaException(string info)
                : base(TextoError + info)
            {
            }
            public AutorizacionFinanciaraInvalidaException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public AutorizacionFinanciaraInvalidaException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class DatosInvalidosException : Exception
        {
            static string TextoError = "Pasivas Consulta Nro Certificado: ";
            public DatosInvalidosException(string descr)
                : base(TextoError + descr)
            {
            }
            public DatosInvalidosException (Exception inner) : base(TextoError, inner)
            {
            }
            public DatosInvalidosException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class PasivasErrorException : Exception
        {
            static string TextoError = "Error con solicitud de Pasivas: ";
            public PasivasErrorException(string descr)
                : base(TextoError + descr)
            {
            }
            public PasivasErrorException()
                : base(TextoError)
            {
            }
            public PasivasErrorException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public PasivasErrorException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class InversorSinPersRelException : Exception
        {
            static string TextoError = "(HOST) Inversor SIN personas relacionadas.";
            public InversorSinPersRelException () : base(TextoError)
            {
            }
            public InversorSinPersRelException (Exception inner) : base(TextoError, inner)
            {
            }
            public InversorSinPersRelException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PersonaSinProdRelException : Exception
        {
            static string TextoError = "(HOST) Producto no encontrado.";
            public PersonaSinProdRelException () : base(TextoError)
            {
            }
            public PersonaSinProdRelException (Exception inner) : base(TextoError, inner)
            {
            }
            public PersonaSinProdRelException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class InversorMasdeCuatroException : Exception
        {
            static string TextoError = "(HOST) El inversor posee mas de 4 titulares";
            public InversorMasdeCuatroException () : base(TextoError)
            {
            }
            public InversorMasdeCuatroException (Exception inner) : base(TextoError, inner)
            {
            }
            public InversorMasdeCuatroException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PersonaInexException : Exception
        {
            static string TextoError = "(HOST) ";
            public PersonaInexException(string descr) : base(TextoError + descr)
            {
            }
            public PersonaInexException (Exception inner) : base(TextoError, inner)
            {
            }
            public PersonaInexException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class TasasParaControlPFException : Exception
        {
            static string TextoError = "(HOST) ";
            public TasasParaControlPFException(string descr)
                : base(TextoError + descr)
            {
            }
            public TasasParaControlPFException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public TasasParaControlPFException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class LecturaSolicitudesAutorizadasException : Exception
        {
            static string TextoError = "(HOST) Lectura de solicitudes autorizadas: ";
            public LecturaSolicitudesAutorizadasException(string descr)
                : base(TextoError + descr)
            {
            }
            public LecturaSolicitudesAutorizadasException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public LecturaSolicitudesAutorizadasException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class LecturaSolicitudesRechazadasException : Exception
        {
            static string TextoError = "(HOST) Lectura de solicitudes rechazadas: ";
            public LecturaSolicitudesRechazadasException(string descr)
                : base(TextoError + descr)
            {
            }
            public LecturaSolicitudesRechazadasException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public LecturaSolicitudesRechazadasException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class CuentaInexException : Exception
        {
            static string TextoError = "(HOST) ";
            public CuentaInexException(string descr)
                : base(TextoError + descr)
            {
            }
            public CuentaInexException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public CuentaInexException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class CuentaInexConIdException : Exception
        {
            public CuentaInexConIdException(string id)
                : base(id)
            {
            }
            public CuentaInexConIdException(string id, string textoError)
                : base("Error obteniendo datos de la cuenta " + id + ": " + textoError)
            {
            }
            static string TextoError = "(HOST) ";
            public CuentaInexConIdException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public CuentaInexConIdException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class CuentaBPInexException : Exception
        {
            public CuentaBPInexException(string Nro)
                : base("CuentaBP " + Nro + " inexistente")
            {
            }
            static string TextoError = "(HOST) ";
            public CuentaBPInexException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public CuentaBPInexException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class ConsBPHostTeamLegajoInexException : Exception
        {
            public ConsBPHostTeamLegajoInexException(string Legajo)
                : base("Legajo " + Legajo + " en vista por team inexistente")
            {
            }
        }
        
        public class ConsBPHostTeamRelacionadoASucErrorException : Exception
        {
            public ConsBPHostTeamRelacionadoASucErrorException(string Mensaje)
                : base("Problemas para obtener el Team de la sucursal.\r\n\r\n" + Mensaje)
            {
            }
        }
        
        public class ConsBPHostIntegrantesTeamErrorException : Exception
        {
            public ConsBPHostIntegrantesTeamErrorException(string Mensaje)
                : base("Problemas para obtener los integrantes del Team.\r\n\r\n" + Mensaje)
            {
            }
        }
        
        public class ConsBPHostXDescrErrorException : Exception
        {
            public ConsBPHostXDescrErrorException(string Mensaje)
                : base(Mensaje)
            {
            }
        }
        
        public class ConsBPHostAllTeamsException : Exception
        {
            public ConsBPHostAllTeamsException()
                : base("Error inesperado en consulta de todos los Teams en BP Host")
            {
            }
        }
        
        public class CuentaIPFInexException : Exception
        {
            public CuentaIPFInexException(string Nro)
                : base("Inversor de plazo fijo " + Nro + " inexistente")
            {
            }
            static string TextoError = "(HOST) ";
            public CuentaIPFInexException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public CuentaIPFInexException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class CuentaCTTEInexException : Exception
        {
            public CuentaCTTEInexException(string Nro)
                : base("Cuenta Comitente " + Nro + " inexistente")
            {
            }
            static string TextoError = "(HOST) ";
            public CuentaCTTEInexException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public CuentaCTTEInexException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }

        
        public class TitularidadException : Exception
        {
            static string TextoError = "(HOST) ";
            public TitularidadException(string descr) : base(TextoError + descr)
            {
            }
            public TitularidadException (Exception inner) : base(TextoError, inner)
            {
            }
            public TitularidadException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CUException : Exception
        {
            static string TextoError = "(HOST) ";
            public CUException(string descr) : base(TextoError + descr)
            {
            }
            public CUException (Exception inner) : base(TextoError, inner)
            {
            }
            public CUException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        namespace MCS
        {
            
            public class BaseApplicationException : Exception
            {
                public BaseApplicationException(string TextoError) : base(TextoError)
                {
                }
                public BaseApplicationException(string TextoError, Exception inner) : base(TextoError, inner)
                {
                }
                public BaseApplicationException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class MCSException  : Microsoft.ApplicationBlocks.ExceptionManagement.Host.MCS.BaseApplicationException
            {
                static string TextoError = "(MCS) ";
                public MCSException(string descr) : base(TextoError + descr)
                {
                }
                public MCSException (Exception inner) : base(TextoError, inner)
                {
                }
                public MCSException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
            
            public class SyRException  : Microsoft.ApplicationBlocks.ExceptionManagement.Host.MCS.BaseApplicationException
            {
                static string TextoError = "(MCS) No se pueden capturar suscripciones y rescates con fecha valor mayor a un día.";
                public SyRException () : base(TextoError)
                {
                }
                public SyRException (Exception inner) : base(TextoError, inner)
                {
                }
                public SyRException (SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
        }
    }
    namespace Login
    {
        
        public class AutenticacionInvalidaException : Exception
        {
            static string TextoError = "Tipo de autenticacion invalida.  Corrija el archivo de configuración.";
            public AutenticacionInvalidaException () : base(TextoError)
            {
            }
            public AutenticacionInvalidaException (Exception inner) : base(TextoError, inner)
            {
            }
            public AutenticacionInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class IdUsuarioNoInfoException : Exception
        {
            static string TextoError = "Nombre del usuario no informado";
            public IdUsuarioNoInfoException () : base(TextoError)
            {
            }
            public IdUsuarioNoInfoException (Exception inner) : base(TextoError, inner)
            {
            }
            public IdUsuarioNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PasswordNoInfoException : Exception
        {
            static string TextoError = "Contraseña no informada";
            public PasswordNoInfoException () : base(TextoError)
            {
            }
            public PasswordNoInfoException (Exception inner) : base(TextoError, inner)
            {
            }
            public PasswordNoInfoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class PasswordNoMatchException : Exception
        {
            static string TextoError = "Contraseña incorrecta";
            public PasswordNoMatchException () : base(TextoError)
            {
            }
            public PasswordNoMatchException (Exception inner) : base(TextoError, inner)
            {
            }
            public PasswordNoMatchException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class UsuarioRevocadoException : Exception
        {
            static string TextoError = "El código de usuario ha sido revocado";
            public UsuarioRevocadoException () : base(TextoError)
            {
            }
            public UsuarioRevocadoException (Exception inner) : base(TextoError, inner)
            {
            }
            public UsuarioRevocadoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class IndefinidoException : Exception
        {
            static string TextoError = "Problema en el login";
            public IndefinidoException()
                : base(TextoError)
            {
            }
            public IndefinidoException(int CodError)
                : base(TextoError + ":" + CodError)
            {
            }
            public IndefinidoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public IndefinidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class NoInformadoException : Exception
        {
            static string TextoError = "Usuario no informado";
            public NoInformadoException()
                : base(TextoError)
            {
            }
            public NoInformadoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public NoInformadoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class UsuarioInvalidoException : Exception
        {
            static string TextoError = "El código de usuario es inválido";
            public UsuarioInvalidoException () : base(TextoError)
            {
            }
            public UsuarioInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public UsuarioInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class UsuarioExpiradoException : Exception
        {
            static string TextoError = "El código de usuario ha expirado";
            public UsuarioExpiradoException () : base(TextoError)
            {
            }
            public UsuarioExpiradoException (Exception inner) : base(TextoError, inner)
            {
            }
            public UsuarioExpiradoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class DestinoInvalidoException : Exception
        {
            static string TextoError = "El destino es inválido";
            public DestinoInvalidoException () : base(TextoError)
            {
            }
            public DestinoInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public DestinoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace DDF
    {
        
        public class DDFInexistenteException : Exception
        {
            static string TextoError = "Definición de Dato Básico/Fórmula/Template inexistente";
            public DDFInexistenteException () : base(TextoError)
            {
            }
            public DDFInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public DDFInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EventoInvalidoException : Exception
        {
            static string TextoError = "Evento inválido";
            public EventoInvalidoException () : base(TextoError)
            {
            }
            public EventoInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EventoInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class EventoIncorrectoException : Exception
        {
            static string TextoError = "Evento incorrecto en el estado actual";
            public EventoIncorrectoException () : base(TextoError)
            {
            }
            public EventoIncorrectoException (Exception inner) : base(TextoError, inner)
            {
            }
            public EventoIncorrectoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class SectoresPtesDataEntryException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "No se puede iniciar el proceso porque hay sectores con carga de datos pendiente\r\n";
            public SectoresPtesDataEntryException(string listaSectores) : base(TextoError + listaSectores)
            {
            }
            public SectoresPtesDataEntryException (Exception inner) : base(TextoError, inner)
            {
            }
            public SectoresPtesDataEntryException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Formula
    {
        
        public class DelimVarIncorrectoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Posición de delimitador de variable incorrecta";
            public DelimVarIncorrectoException(int posicion) : base(TextoError + " (Pos " + posicion + ")")
            {
            }
            public DelimVarIncorrectoException (Exception inner) : base(TextoError, inner)
            {
            }
            public DelimVarIncorrectoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ParentesisNoBalanceanException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "No balancean los parentesis";
            public ParentesisNoBalanceanException () : base(TextoError)
            {
            }
            public ParentesisNoBalanceanException (Exception inner) : base(TextoError, inner)
            {
            }
            public ParentesisNoBalanceanException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class VarInesperadaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "No se esperaba una variable";
            public VarInesperadaException(int posicion) : base(TextoError + " (Pos " + posicion + ")")
            {
            }
            public VarInesperadaException (Exception inner) : base(TextoError, inner)
            {
            }
            public VarInesperadaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class OperInesperadoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "No se esperaba un operador";
            public OperInesperadoException(int posicion) : base(TextoError + " (Pos " + posicion + ")")
            {
            }
            public OperInesperadoException (Exception inner) : base(TextoError, inner)
            {
            }
            public OperInesperadoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class ApertParIncorrectaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Apertura de parentesis incorrecta";
            public ApertParIncorrectaException(int posicion) : base(TextoError + " (Pos " + posicion + ")")
            {
            }
            public ApertParIncorrectaException (Exception inner) : base(TextoError, inner)
            {
            }
            public ApertParIncorrectaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CierreParIncorrectaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Cierre de parentesis incorrecto";
            public CierreParIncorrectaException(int posicion) : base(TextoError + " (Pos " + posicion + ")")
            {
            }
            public CierreParIncorrectaException (Exception inner) : base(TextoError, inner)
            {
            }
            public CierreParIncorrectaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class DDFInexistenteException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Dato Básico, o Fórmula, inexistente: ";
            public DDFInexistenteException(string IdDDF) : base(TextoError + " [" + IdDDF + "]")
            {
            }
            public DDFInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public DDFInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class CaracterInvalidoException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Caracter inválido";
            public CaracterInvalidoException(int posicion) : base(TextoError + " (Pos " + posicion + ")")
            {
            }
            public CaracterInvalidoException (Exception inner) : base(TextoError, inner)
            {
            }
            public CaracterInvalidoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class FaltanOperandosException  : Microsoft.ApplicationBlocks.ExceptionManagement.Validaciones.BaseApplicationException
        {
            static string TextoError = "Faltan operandos";
            public FaltanOperandosException () : base(TextoError)
            {
            }
            public FaltanOperandosException (Exception inner) : base(TextoError, inner)
            {
            }
            public FaltanOperandosException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Aplicacion
    {
        
        public class AssemblyVersionInvalidaException  : Microsoft.ApplicationBlocks.ExceptionManagement.Sesion.BaseApplicationException
        {
            static string TextoError = "Versión desactualizada";
            public AssemblyVersionInvalidaException(string VersionNoActualizada, string VersionVigente)
                : base("La versión que se esta ejecutando (" + VersionNoActualizada + ") no está actualizada.\r\nSolicite la instalación del release más actualizado de la  versión " + VersionVigente + " en el servidor " + System.Net.Dns.GetHostName())
            {
            }
            public AssemblyVersionInvalidaException (Exception inner) : base(TextoError, inner)
            {
            }
            public AssemblyVersionInvalidaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace Teams
    {
        
        public class UsuarioSinPermisoException : Exception
        {
            static string TextoError = " El usuario ";
            static string TextoError2 = " no tiene permisos para realizar esta acción bajo el rol ";
            public UsuarioSinPermisoException(string IdUsuario, string DescrRol) : base(TextoError + IdUsuario + TextoError2 + DescrRol)
            {
            }
        }

        
        public class UsuarioDadoDeBajaException : Exception
        {
            static string TextoError = " El usuario ";
            static string TextoError2 = " esta dado de baja ";
            public UsuarioDadoDeBajaException(string IdUsuario)
                : base(TextoError + IdUsuario + TextoError2)
            {
            }
        }
        
        public class UsuarioSinNingunTeamException : Exception
        {
            static string TextoError = " El usuario ";
            static string TextoError2 = " no pertenece a ningún team ";
            public UsuarioSinNingunTeamException(string IdUsuario) : base(TextoError + IdUsuario + TextoError2)
            {
            }
        }
        
        public class SoloJerarquiaComercialException : Exception
        {
            static string TextoError = " El usuario ";
            static string TextoError2 = " no puede realizar esta operacion. Solo la puede realizar Jerarquia Comercial ";
            public SoloJerarquiaComercialException(string IdUsuario)
                : base(TextoError + IdUsuario + TextoError2)
            {
            }
        }
    }
    namespace CapturaCedPM
    {
        
        public class ElementoInexistenteException : Exception
        {
            static string TextoError = " inexistente ";
            public ElementoInexistenteException(string Elemento, string IdUN) : base(Elemento + TextoError + "para IdFCI:" + IdUN)
            {
            }
            public ElementoInexistenteException(string Elemento) : base(Elemento + TextoError)
            {
            }
            public ElementoInexistenteException (Exception inner) : base(TextoError, inner)
            {
            }
            public ElementoInexistenteException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class OperacionIncorporadaException : Exception
        {
            static string TextoError = "ya ha sido incorporada";
            public OperacionIncorporadaException () : base(TextoError)
            {
            }
            public OperacionIncorporadaException (Exception inner) : base(TextoError, inner)
            {
            }
            public OperacionIncorporadaException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        
        public class IdTMovNoEncontradoException : Exception
        {
            static string TextoError = "IdTMov (CedPM) no encontrado";
            public IdTMovNoEncontradoException () : base(TextoError)
            {
            }
            public IdTMovNoEncontradoException (Exception inner) : base(TextoError, inner)
            {
            }
            public IdTMovNoEncontradoException (SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
    namespace WS
    {
        
        public class MensajeErrorWSCPException : Exception
        {
            static string TextoError = "Error en WS: ";
            public MensajeErrorWSCPException()
                : base(TextoError)
            {
            }
            public MensajeErrorWSCPException(string Elemento) : base(TextoError + Elemento)
            {
            }
            public MensajeErrorWSCPException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public MensajeErrorWSCPException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
    namespace CedeiraPFproxy
    {
        
        public class BaseApplicationException : Exception
        {
            public BaseApplicationException(string TextoError)
                : base(TextoError)
            {
            }
            public BaseApplicationException(string TextoError, Exception inner)
                : base(TextoError, inner)
            {
            }
            public BaseApplicationException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class ConfirmacionException : Exception
        {
            static string TextoError = "Respuesta de Confirmacion de Precálculo con severidad 'error'.  ";
            public ConfirmacionException(string Detalle)
                : base(TextoError + Detalle)
            {
            }
            public ConfirmacionException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public ConfirmacionException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class ConsultaPrecalculoException : Exception
        {
            static string TextoError = "Respuesta de Consulta de Precálculo con severidad 'error'.  ";
            public ConsultaPrecalculoException(string Detalle)
                : base(TextoError + Detalle)
            {
            }
            public ConsultaPrecalculoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public ConsultaPrecalculoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class AdminPteSucException : Exception
        {
            static string TextoError = "Respuesta de Alta en Bandeja de Pendientes de Sucursales con severidad 'error'.  ";
            public AdminPteSucException(string Detalle)
                : base(TextoError + Detalle)
            {
            }
            public AdminPteSucException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public AdminPteSucException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
        
        public class ImpactoException : Exception
        {
            static string TextoError = "Respuesta de Impacto en SAP con severidad 'error'.  ";
            public ImpactoException(string Detalle)
                : base(TextoError + Detalle)
            {
            }
            public ImpactoException(Exception inner)
                : base(TextoError, inner)
            {
            }
            public ImpactoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
    public class MapperException : Exception
    {
        public MapperException() : base() { }
        public MapperException(string mensje) : base(mensje) { }
        public MapperException(string mensje, Exception ex) : base(mensje, ex) { }
    }
}
