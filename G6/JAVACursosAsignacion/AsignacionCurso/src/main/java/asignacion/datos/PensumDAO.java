
package asignacion.datos;

import asignacion.dominio.Pensum;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;


public class PensumDAO {
    
    private static final  String SQL_SELECT = "SELECT idFacultad, idJornada, idCarrera, idPensum FROM facultades" +" SELECT idCURSO, nombre FROM cursos";
    private String SQL_QUERY;
    
     public List<Pensum> select() {
        Connection conn = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;
        Pensum pensumcp = null;
        List<Pensum> pensumcp2 = new ArrayList <Pensum>();

        try {
            conn = (Connection) Conexion.getConnection();
            stmt = conn.prepareStatement(SQL_SELECT);
            rs = stmt.executeQuery();
            while (rs.next()) {
                String idFacultad = rs.getString("idFacultad");
                String idJornada = rs.getString("idJornada");
                String idCarrera = rs.getString("idCarrera");
                String idPensum = rs.getString("idPensum");
                String idCurso = rs.getString("idCurso");
                String nombre = rs.getString("nombre");
                
                 
                pensumcp = new Pensum();
                pensumcp.setIdFacultad(idFacultad);
                pensumcp.setIdJornada(idJornada);
                pensumcp.setIdCarrera(idCarrera);
                pensumcp.setIdPensum(idPensum);
                pensumcp.setIdCURSO(idCurso);
                pensumcp.setNombre(nombre);
                
                pensumcp2.add(pensumcp);
            }

        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        } finally {
            Conexion.close(rs);
            Conexion.close(stmt);
            Conexion.close((ResultSet) conn);
        }

        return pensumcp2;
    }
     
    /**
     *
     * @param pensum
     * @return
     */
    public Pensum query(Pensum pensum) {    
        Connection conn = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;
        List<Pensum> pensum2 = new ArrayList<Pensum>();
        int rows = 0;

        try {
            conn = (Connection) Conexion.getConnection();
            System.out.println("Ejecutando query:" + SQL_QUERY);
            stmt = conn.prepareStatement(SQL_QUERY);
            stmt.setString(1, pensum.getIdFacultad());
            rs = stmt.executeQuery();
            while (rs.next()) {
               String idFacultad = rs.getString("idFacultad");
               String idJornada = rs.getString("idJornada");
               String idCarrera = rs.getString("idCarrera");
               String idPensum = rs.getString("idPensum");
               String idCurso = rs.getString("idCurso");
               String nombre = rs.getString("nombre");
                
                
                pensum = new Pensum();
                pensum.setIdFacultad(idFacultad);
                pensum.setIdJornada(idJornada);
                pensum.setIdCarrera(idCarrera);
                pensum.setIdPensum(idPensum);
                pensum.setIdCURSO(idCurso);
                pensum.setNombre(nombre);

                
            }
        
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        } finally {
            Conexion.close(rs);
            Conexion.close(stmt);
            Conexion.close((ResultSet) conn);
        }
        return pensum;
    } 
  
}
