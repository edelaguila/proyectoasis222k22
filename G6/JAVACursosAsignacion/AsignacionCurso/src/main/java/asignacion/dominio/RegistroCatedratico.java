/*
* DIANA VICTORES
 * 9959-19-1471
 * REGISTRO CATEDRATICOS
 *
 */
package asignacion.dominio;

/**
 *
 * @author Diana
 */
public class RegistroCatedratico {
    String idCat;
    String nombres;
    String apellidos;
    String dpi;
    String idDir;
    String idCorreo;
    String idTel;
    
    
    public String getIdCat() {
        return idCat;
    }

    public void setIdCat(String idCat) {
        this.idCat = idCat;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getDpi() {
        return dpi;
    }

    public void setDpi(String dpi) {
        this.dpi = dpi;
    }

    public String getIdDir() {
        return idDir;
    }

    public void setIdDir(String idDir) {
        this.idDir = idDir;
    }

    public String getIdCorreo() {
        return idCorreo;
    }

    public void setIdCorreo(String idCorreo) {
        this.idCorreo = idCorreo;
    }

    public String getIdTel() {
        return idTel;
    }

    public void setIdTel(String idTel) {
        this.idTel = idTel;
    }

    @Override
    public String toString() {
        return "RegistroCatedratico{" + "idCat=" + idCat + ", nombres=" + nombres + ", apellidos=" + apellidos + ", dpi=" + dpi + ", idDir=" + idDir + ", idCorreo=" + idCorreo + ", idTel=" + idTel + '}';
    }


    
    
}
