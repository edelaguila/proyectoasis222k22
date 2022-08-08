
package asignacion.datos;

import asignacion.dominio.CursosCatedraticos;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;


public class CursosCatedraticosDAO {
    
     private static final  String SQL_SELECT = "SELECT idCat, nombres, apellidos FROM catedratico" +" SELECT idCurso, nombre, seccion,idHorario, FROM cursos";
    private String SQL_QUERY;
    
     public List<CursosCatedraticos> select() {
        Connection conn = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;
        CursosCatedraticos cursoscat = null;
        List<CursosCatedraticos> cursoscat2 = new ArrayList <CursosCatedraticos>();

        try {
            conn = (Connection) Conexion.getConnection();
            stmt = conn.prepareStatement(SQL_SELECT);
            rs = stmt.executeQuery();
            while (rs.next()) {
                String idCat = rs.getString("idCat");
                String nombres = rs.getString("nombres");
                String apellidos = rs.getString("apellidos");
                String idCurso = rs.getString("idCURSO");
                String nombre = rs.getString("nombre");
                String seccion = rs.getString("seccion");
                String idHorario = rs.getString("idhorario");
                
                 
                cursoscat = new CursosCatedraticos();
                cursoscat.setIdCat(idCat);
                cursoscat.setNombres(nombres);
                cursoscat.setApellidos(apellidos);
                cursoscat.setIdCURSO(idCurso);
                cursoscat.setNombre(nombre);
                cursoscat.setSeccion(seccion);
                cursoscat.setIdhorario(idHorario);
                
                cursoscat2.add(cursoscat);
            }

        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        } finally {
            Conexion.close(rs);
            Conexion.close(stmt);
            Conexion.close((ResultSet) conn);
        }

        return cursoscat2;
    }
     
    public CursosCatedraticos query(CursosCatedraticos cursoscatedraticos) {    
        Connection conn = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;
        List<CursosCatedraticos> cursoscatedraticos2 = new ArrayList<CursosCatedraticos>();
        int rows = 0;

        try {
            conn = (Connection) Conexion.getConnection();
            System.out.println("Ejecutando query:" + SQL_QUERY);
            stmt = conn.prepareStatement(SQL_QUERY);
            stmt.setString(1, cursoscatedraticos.getIdCat());
            rs = stmt.executeQuery();
            while (rs.next()) {
                String idCat = rs.getString("idCat");
                String nombres = rs.getString("nombres");
                String apellidos = rs.getString("apellidos");
                String idcurso = rs.getString("idCURSO");
                String nombre = rs.getString("nombre");
                String seccion = rs.getString("seccion");
                String idHorario = rs.getString("idhorario");
                
                cursoscatedraticos = new CursosCatedraticos();
                cursoscatedraticos.setIdCat(idCat);
                cursoscatedraticos.setNombres(nombres);
                cursoscatedraticos.setApellidos(apellidos);
                cursoscatedraticos.setIdCURSO(idcurso);
                cursoscatedraticos.setNombre(nombre);
                cursoscatedraticos.setSeccion(seccion);
                cursoscatedraticos.setIdhorario(idHorario);

                //empleados.add(empleado); // Si se utiliza un ArrayList
            }
            //System.out.println("Registros buscado:" + empleado);
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        } finally {
            Conexion.close(rs);
            Conexion.close(stmt);
            Conexion.close((ResultSet) conn);
        }

        
        return cursoscatedraticos;
    }
}
