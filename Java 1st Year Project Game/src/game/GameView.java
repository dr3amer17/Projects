package game;
import city.cs.engine.*;
import javax.swing.*;
import java.awt.*;
/**
 * The GameView class controls how the game is displayed to the player.
 *
 * It handles:
 * - Drawing different background images for different levels
 * - Drawing the hero's health bar and HP value on the screen
 */
public class GameView extends UserView {
    private Hero hero;
    private Image background1;
    private Image background2;
    private Image background3;
    private Image defaultBackground;

    public GameView(GameWorld world, int width, int height) {
        super(world, width, height);
        this.hero = world.getHero();

        // Load backgrounds
        background1 = new ImageIcon("data/10.png").getImage();
        background2 = new ImageIcon("data/11.png").getImage();
        background3 = new ImageIcon("data/12.png").getImage();
    }

    public void setHero(Hero hero) {
        this.hero = hero;
    }
    // Background image adding methos
    @Override
    protected void paintBackground(Graphics2D g) {
        if (getWorld() instanceof Level1) {
            g.drawImage(background1, 0, 0, getWidth(), getHeight(), this);
        } else if (getWorld() instanceof Level2) {
            g.drawImage(background2, 0, 0, getWidth(), getHeight(), this);
        } else if (getWorld() instanceof Level3) {
            g.drawImage(background3, 0, 0, getWidth(), getHeight(), this);
        } else {
            g.drawImage(defaultBackground, 0, 0, getWidth(), getHeight(), this);
        }
    }

    @Override
    protected void paintForeground(Graphics2D g) {
        g.setColor(Color.RED);
        g.fillRect(20, 20, hero.getHp() * 2, 20); // Health bar
        g.setColor(Color.BLACK);
        g.drawRect(20, 20, 200, 20); // Health bar border
        // Draw HP number
        g.setColor(Color.WHITE); // text color
        g.setFont(new Font("Arial", Font.BOLD, 14));
        g.drawString("HP: " + hero.getHp(), 25, 35); // (x, y) position of text
    }
}
