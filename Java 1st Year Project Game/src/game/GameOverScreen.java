package game;
import javax.swing.*;
import java.awt.*;
/**
 * The GameOverScreen class creates a simple window
 * that displays "YOU DIED" when the hero loses all health.
 */
public class GameOverScreen {
    public GameOverScreen() {
        JFrame frame = new JFrame("Game Over");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 200);

        JLabel label = new JLabel("YOU DIED ", SwingConstants.CENTER);
        label.setFont(new Font("Arial", Font.BOLD, 32));
        frame.getContentPane().add(label);

        frame.setLocationRelativeTo(null); // Center window
        frame.setVisible(true);
    }
}
