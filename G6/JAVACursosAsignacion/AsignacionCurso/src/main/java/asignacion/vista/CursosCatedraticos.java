/* 
Josue Amaya 0901-19-12421
Cursos catedraticos : Vista de cursos asignados a catedraticos
*/

package asignacion.vista;

import asignacion.datos.CursosCatedraticosDAO;
import java.util.List;
import javax.swing.table.DefaultTableModel;


public class CursosCatedraticos extends javax.swing.JPanel {

    /**
     * Creates new form CursosCatedraticos
     */
    public CursosCatedraticos() {
        
        initComponents();
        jPanelCCat.setVisible(true);
        jPanelCatBusca.setVisible(false);
    }

    public void mostrartabla()
    {
        DefaultTableModel tableC = new DefaultTableModel();
        tableC.addColumn("No");
        tableC.addColumn("Curso");
        tableC.addColumn("Codigo");
        tableC.addColumn("Seccion");
        tableC.addColumn("Horario");
        
        TableCursos.setModel(tableC);
        
        CursosCatedraticosDAO cursoscatDAO = new CursosCatedraticosDAO();
        
        List<asignacion.dominio.CursosCatedraticos> listado = cursoscatDAO.select();
        
        String[] dato = new String[6];
        for(int i = 0; i < listado.size(); i++){
        dato[0] = listado.get(i).getIdCat();
        dato[1] = listado.get(i).getnombres();
        dato[2] = listado.get(i).getapellidos();
        dato[3] = listado.get(i).getnombre();
        dato[4] = listado.get(i).getseccion();
        dato[5] = listado.get(i).getIdhorario();

        tableC.addRow(dato);
    }
    }
   
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel3 = new javax.swing.JLabel();
        jFrame1 = new javax.swing.JFrame();
        jPanelCCat = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        txtcodcat = new javax.swing.JTextField();
        txtyearcat = new javax.swing.JTextField();
        optionSTcat = new javax.swing.JComboBox<>();
        btnConsultar = new javax.swing.JButton();
        jSeparator1 = new javax.swing.JSeparator();
        jPanelCatBusca = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        TableCursos = new javax.swing.JTable();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();

        jLabel3.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel3.setText("Año");

        javax.swing.GroupLayout jFrame1Layout = new javax.swing.GroupLayout(jFrame1.getContentPane());
        jFrame1.getContentPane().setLayout(jFrame1Layout);
        jFrame1Layout.setHorizontalGroup(
            jFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 400, Short.MAX_VALUE)
        );
        jFrame1Layout.setVerticalGroup(
            jFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 300, Short.MAX_VALUE)
        );

        setMinimumSize(new java.awt.Dimension(773, 516));
        setPreferredSize(new java.awt.Dimension(773, 516));

        jPanelCCat.setBackground(javax.swing.UIManager.getDefaults().getColor("Button.highlight"));

        jLabel1.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel1.setText("Codigo Catedratico :");

        jLabel2.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel2.setText("Año :");

        jLabel4.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel4.setText("Semestre / Trimestre :");

        optionSTcat.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        optionSTcat.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Selecciona", "1", "2", "3", "4" }));

        btnConsultar.setFont(new java.awt.Font("Arial", 0, 12)); // NOI18N
        btnConsultar.setText("Consultar");
        btnConsultar.setPreferredSize(new java.awt.Dimension(85, 38));
        btnConsultar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnConsultarActionPerformed(evt);
            }
        });

        jSeparator1.setForeground(new java.awt.Color(0, 0, 0));

        javax.swing.GroupLayout jPanelCCatLayout = new javax.swing.GroupLayout(jPanelCCat);
        jPanelCCat.setLayout(jPanelCCatLayout);
        jPanelCCatLayout.setHorizontalGroup(
            jPanelCCatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelCCatLayout.createSequentialGroup()
                .addGap(37, 37, 37)
                .addGroup(jPanelCCatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1)
                    .addComponent(jLabel2)
                    .addComponent(jLabel4))
                .addGap(33, 33, 33)
                .addGroup(jPanelCCatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(txtcodcat)
                    .addComponent(txtyearcat)
                    .addComponent(optionSTcat, 0, 125, Short.MAX_VALUE))
                .addGap(117, 117, 117)
                .addComponent(btnConsultar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addComponent(jSeparator1, javax.swing.GroupLayout.Alignment.TRAILING)
        );
        jPanelCCatLayout.setVerticalGroup(
            jPanelCCatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelCCatLayout.createSequentialGroup()
                .addContainerGap(30, Short.MAX_VALUE)
                .addGroup(jPanelCCatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(txtcodcat, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanelCCatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txtyearcat, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanelCCatLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(optionSTcat, javax.swing.GroupLayout.PREFERRED_SIZE, 29, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnConsultar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(jSeparator1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        jPanelCatBusca.setBackground(javax.swing.UIManager.getDefaults().getColor("Button.highlight"));

        TableCursos.setFont(new java.awt.Font("Arial", 0, 12)); // NOI18N
        TableCursos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        jScrollPane1.setViewportView(TableCursos);

        jLabel5.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel5.setText("Catedratico :");

        jLabel6.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jLabel6.setText("Nombre Catedratico");

        javax.swing.GroupLayout jPanelCatBuscaLayout = new javax.swing.GroupLayout(jPanelCatBusca);
        jPanelCatBusca.setLayout(jPanelCatBuscaLayout);
        jPanelCatBuscaLayout.setHorizontalGroup(
            jPanelCatBuscaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanelCatBuscaLayout.createSequentialGroup()
                .addContainerGap(32, Short.MAX_VALUE)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 695, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(26, 26, 26))
            .addGroup(jPanelCatBuscaLayout.createSequentialGroup()
                .addGap(41, 41, 41)
                .addComponent(jLabel5)
                .addGap(53, 53, 53)
                .addComponent(jLabel6)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanelCatBuscaLayout.setVerticalGroup(
            jPanelCatBuscaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelCatBuscaLayout.createSequentialGroup()
                .addGap(35, 35, 35)
                .addGroup(jPanelCatBuscaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(jLabel6))
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(143, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanelCCat, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanelCatBusca, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanelCCat, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanelCatBusca, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void btnConsultarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConsultarActionPerformed
        
        String optst = (String) optionSTcat.getSelectedItem();
        String codcat = txtcodcat.getText();
        String yearcat = txtyearcat.getText();
        
        asignacion.dominio.CursosCatedraticos catbuscar = new asignacion.dominio.CursosCatedraticos();
        asignacion.datos.CursosCatedraticosDAO cursoscatedraticosDAO = new CursosCatedraticosDAO();
        catbuscar = cursoscatedraticosDAO.query(catbuscar);
        
        if (codcat.equals(catbuscar.getIdCat())) {
            jPanelCatBusca.setVisible(true);
            mostrartabla();
        }
       
    }//GEN-LAST:event_btnConsultarActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTable TableCursos;
    private javax.swing.JButton btnConsultar;
    private javax.swing.JFrame jFrame1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JPanel jPanelCCat;
    private javax.swing.JPanel jPanelCatBusca;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JComboBox<String> optionSTcat;
    private javax.swing.JTextField txtcodcat;
    private javax.swing.JTextField txtyearcat;
    // End of variables declaration//GEN-END:variables

}
