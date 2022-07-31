//se importan todas las librerias necesarias
import java.awt.BorderLayout;
import java.io.File;
import javafx.embed.swing.JFXPanel;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.media.Media;
import javafx.scene.media.MediaException;
import javafx.scene.media.MediaPlayer;
import javafx.scene.media.MediaView;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

public class reproduce {
    // acá estan todas las variables y objetos que se van a utilizar en la clase
    private JFXPanel jfxpanel;
    private JPanel jpanel;
    private MediaPlayer mediaplayer;
    private Media media;
    private MediaView mediaView;
    private Scene escena;
    private File file;
    private String ruta;
    
    
    //ahora se van a detallar cada uno de los metodos

    public reproduce() {
        this.jfxpanel = new JFXPanel();
    } // esre metodo instancia mi primer objeto

    /**
     * @param jpanel the jpanel to set
     */
    public void setJpanel(JPanel jpanel) {
        this.jpanel = jpanel;
    }

    /**
     * @return the mediaplayer
     */
    public MediaPlayer getMediaplayer() {
        return mediaplayer;
    }

    /**
     * @param ruta the ruta to set
     */
    public void setRuta(String ruta) {
        this.ruta = ruta;
    }
    
    //este metodo controla el play del video
    public void reproducir(){
        try {
            this.getMediaplayer().play();
        }catch(MediaException e){
            System.out.println("Error; "+e.getMessage());
        }
    }
    
    //con este metodo podremos pausar el video
    public void pausar(){
        try {
            this.getMediaplayer().pause();
        }catch(MediaException e){
            System.out.println("Error; "+e.getMessage());
        }
    }
    
    //este se encarga de parar el video
    public void parar(){
        try {
            this.getMediaplayer().stop();    
        }catch(MediaException e){
            System.out.println("Error; "+e.getMessage());
        }
    }
    
    //con este metodo podre controlar el volumen del video
    public void volumen(double valor){
        try {
            this.getMediaplayer().setVolume(valor);
        }catch(MediaException e){
            System.out.println("Error; "+e.getMessage());
        }
    }
    
    
    public void mostrarvideo(){
        try{
            int x = this.jpanel.getHeight();
            int y = this.jpanel.getWidth();
            
            this.file = new File(this.ruta);
            this.media = new Media(this.file.toURI().toString());
            this.mediaplayer = new MediaPlayer(this.media);
            this.mediaView = new MediaView(this.mediaplayer);
            //va a definir en que tamaño se va a reproducir nuestro video
            //dependiendo del tamaño del panel
            this.mediaView.setFitHeight(x);
            this.mediaView.setFitWidth(x);
            
            this.escena = new Scene(new Group(this.mediaView));
            
            this.jfxpanel.setSize(this.jpanel.getSize());
            this.jfxpanel.setScene(this.escena);
            
            this.getMediaplayer().setCycleCount(MediaPlayer.INDEFINITE);
            
            this.jpanel.setLayout(new BorderLayout());
            this.jpanel.add(this.jfxpanel,BorderLayout.CENTER);
            
            
        }catch(MediaException e){
            JOptionPane.showMessageDialog(null, "ESTO NO ES UN TRAILER", "ERROR", JOptionPane.ERROR_MESSAGE);
        }
    }
    
}
