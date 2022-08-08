
package asignacion.datos;

import asignacion.dominio.AsignacionCursos;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;



public class AsignacionCursosDAO {

private static final String SQL_SELECT = "SELECT idAlumno, nombres, Apellidos FROM  alumno"
        + "SELECT IdAlumno, Id_Curso1, Curso_1, Id_Curso2, Curso_2, Id_Curso3, Curso_3, Id_Curso4, Curso_4, Id_Curso5, Curso_5, Id_Curso_Ext1, Curso_Extraordinario_1, Id_Curso_Ext2, Curso_Extraordinario_2, Id_Curso_Ext3, Curso_Extraordinario_3 FROM CursosDisponibles" + 
        "SELECT IdCurso, Seccion_A, Seccion_B, Seccion_C, Seccion_D FROM SecYHor";


private static final String SQL_INSERT = "INSERT INTO CursosAsignados (carnet, Nombres, Apellidos, Boleta_Pago_Numero, Semestre_Trimestre, Año, Curso_1, Curso_2, Curso_3, Curso_4, Curso_5, Curso_Extraordinario_1, Curso_Extraordinario_2, Curso_Extraordinario_3)"
        + "VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?) ";

private static final String SQL_QUERY = "SELECT idAlumno, nombres, Apellidos FROM alumno WHERE idAlumno=?";

 
 
 public List<AsignacionCursos> select() {
        Connection conn = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;
        AsignacionCursos asignacioncurso = null;
        List<AsignacionCursos> asignacioncursos = new ArrayList <AsignacionCursos>();

        try {
            conn = (Connection) Conexion.getConnection();
            stmt = conn.prepareStatement(SQL_SELECT);
            rs = stmt.executeQuery();
            while (rs.next()) {
                String idAlumno = rs.getString("idAlumno");
                String nombres = rs.getString("nombres");
                String Apellidos = rs.getString("Apellidos");
                String IdAlumno = rs.getString("IdAlumnoCD");
                String Id_Curso1 = rs.getString("idc1");
                String Curso_1 = rs.getString("curso1");
                String Id_Curso2 = rs.getString("idc2");
                String Curso_2 = rs.getString("curso2");
                String Id_Curso3 = rs.getString("idc3");
                String Curso_3 = rs.getString("curso3");
                String Id_Curso4 = rs.getString("idc4");
                String Curso_4 = rs.getString("curso4");
                String Id_Curso5 = rs.getString("idc5");
                String Curso_5 = rs.getString("curso5");
                String Id_Curso_Ext1 = rs.getString("idce1");
                String Curso_Extraordinario_1 = rs.getString("cursoe1");
                String Id_Curso_Ext2 = rs.getString("idce2");
                String Curso_Extraordinario_2 = rs.getString("cursoe2");
                String Id_Curso_Ext3 = rs.getString("idce3");
                String Curso_Extraordinario_3 = rs.getString("cursoe3");
                String IdCurso = rs.getString("idsecyhor");
                String Seccion_A = rs.getString("secA");
                String Seccion_B = rs.getString("secB");
                String Seccion_C = rs.getString("secC");
                String Seccion_D = rs.getString("secD");
                
                 
                 
                asignacioncurso = new AsignacionCursos();
                asignacioncurso.setIdAlumno(idAlumno);
                asignacioncurso.setNombres(nombres);
                asignacioncurso.setApellidos(Apellidos);
                asignacioncurso.setIdAlumnoCD(IdAlumno);
                asignacioncurso.setIdc1(Id_Curso1);
                asignacioncurso.setCurso1(Curso_1);
                asignacioncurso.setIdc2(Id_Curso2);
                asignacioncurso.setCurso2(Curso_2);
                asignacioncurso.setIdc3(Id_Curso3);
                asignacioncurso.setCurso3(Curso_3);
                asignacioncurso.setIdc4(Id_Curso4);
                asignacioncurso.setCurso4(Curso_4);
                asignacioncurso.setIdc5(Id_Curso5);
                asignacioncurso.setCurso5(Curso_5);
                asignacioncurso.setIdce1(Id_Curso_Ext1);
                asignacioncurso.setCursoe1(Curso_Extraordinario_1);
                asignacioncurso.setIdce2(Id_Curso_Ext2);
                asignacioncurso.setCursoe2(Curso_Extraordinario_2);
                asignacioncurso.setIdce3(Id_Curso_Ext3);
                asignacioncurso.setCursoe3(Curso_Extraordinario_3);
                asignacioncurso.setIdsecyhor(IdCurso);
                asignacioncurso.setSecA(Seccion_A);
                asignacioncurso.setSecB(Seccion_B);
                asignacioncurso.setSecC(Seccion_C);
                asignacioncurso.setSecD(Seccion_D);
                
                
                asignacioncursos.add(asignacioncurso);
            }

        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        } finally {
            Conexion.close(rs);
            Conexion.close(stmt);
            Conexion.close((ResultSet) conn);
        }

        return asignacioncursos;
    }
 
  public int insert(AsignacionCursos asigcursos) {
        Connection conn = null;
        PreparedStatement stmt = null;
        int rows = 0;
        try {
            conn = (Connection) Conexion.getConnection();
            stmt = conn.prepareStatement(SQL_INSERT);
            stmt.setString(1,asigcursos.getIdAlumno());
            stmt.setString(2, asigcursos.getNombres());
            stmt.setString(3, asigcursos.getApellidos());
            stmt.setString(4, asigcursos.getBpago());
            stmt.setString(5, asigcursos.getSemtrim());
            stmt.setString(6, asigcursos.getYearasig());
            stmt.setString(7, asigcursos.getCurso1());
            stmt.setString(8, asigcursos.getCurso2());
            stmt.setString(9, asigcursos.getCurso3());
            stmt.setString(10, asigcursos.getCurso4());
            stmt.setString(11, asigcursos.getCurso5());
            stmt.setString(12, asigcursos.getCursoe1());
            stmt.setString(13, asigcursos.getCursoe2());
            stmt.setString(14, asigcursos.getCursoe3());
            stmt.setString(rows, SQL_QUERY);
            
             //System.out.println("ejecutando query:" + SQL_INSERT);
            rows = stmt.executeUpdate();
            //System.out.println("Registros afectados:" + rows);
            JOptionPane.showMessageDialog(null, "Asignacion Exitosa");
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        } finally {
            Conexion.close(stmt);
            Conexion.close((ResultSet) conn);
        }

        return rows;
    }
  
  public AsignacionCursos query(AsignacionCursos asigcursos) {    
        Connection conn = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;
        List<AsignacionCursos> asignacioncursos = new ArrayList<AsignacionCursos>();
        int rows = 0;

        try {
            conn = (Connection) Conexion.getConnection();
            System.out.println("Ejecutando query:" + SQL_QUERY);
            stmt = conn.prepareStatement(SQL_QUERY);
            stmt.setString(1, asigcursos.getIdAlumno());
            rs = stmt.executeQuery();
            while (rs.next()) {
               String idAlumno = rs.getString("idAlumno");
               String Nombres = rs.getString("nombres");
               String Apellidos = rs.getString("Apellidos");
                
                asigcursos = new AsignacionCursos();
                asigcursos.setIdAlumno(idAlumno);
                asigcursos.setNombres(Nombres);
                asigcursos.setApellidos(Apellidos);

                
            }
        
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        } finally {
            Conexion.close(rs);
            Conexion.close(stmt);
            Conexion.close((ResultSet) conn);
        }
        return asigcursos;
    } 
    
}
