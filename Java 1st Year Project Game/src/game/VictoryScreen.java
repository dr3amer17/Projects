package game;
import javax.swing.*;
import java.awt.*;

/**
 * The VictoryScreen class creates a simple window
 */
public class VictoryScreen {
    public VictoryScreen() {
        JFrame frame = new JFrame("Victory!");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 200);

        JLabel label = new JLabel("YOU WIN!", SwingConstants.CENTER);
        label.setFont(new Font("Arial", Font.BOLD, 32));

        frame.getContentPane().add(label);
        frame.setLocationRelativeTo(null); // Center window
        frame.setVisible(true);
    }
}
