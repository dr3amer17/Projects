package game;
import city.cs.engine.*;
import org.jbox2d.common.Vec2;
import javax.swing.JFrame;
/**
 * The main Game class that controls the overall flow of the game.
 *
 * It handles:
 * - Initializing the first level
 * - Managing transitions between levels
 * - Managing the Hero and View
 * - Playing background music
 */
public class Game {
    private int level;
    private GameWorld world;
    private Hero hero;
    private GameView view;
    /**
     * Constructor for Game.
     * Sets up the initial game window, world, hero, and starts background music.
     */
    public Game() {
        level = 1;
        world = new Level1();
        world.populate(this);
        hero = world.getHero();
        hero.setGame(this);

        view = new GameView(world, 800, 600);
        view.setFocusable(true);

        HeroController controller = new HeroController(hero);
        view.addKeyListener(controller);

        JFrame frame = new JFrame("My Game");
        frame.add(view);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setResizable(false);
        frame.pack();
        frame.setLocationByPlatform(true);
        frame.setVisible(true);

        Music music = new Music();
        music.playMusic("data/theme.wav");

        world.start();
        view.requestFocus();
    }
    /**
     * Moves the Hero to the next level when called.
     * Displays a victory screen after completing all levels.
     */
    public void goToNextLevel() {
        world.stop();
        int previousHp = hero.getHp(); // Save hero HP
        boolean previousHasGun = hero.hasGun();

        if (level == 1) {
            level = 2;
            world = new Level2();
        } else if (level == 2) {
            level = 3;
            world = new Level3();
        } else {
            System.out.println("You finished all levels!");
            new VictoryScreen();
            return;
        }

        world.populate(this);
        hero = world.getHero();
        hero.setGame(this);
        hero.setHp(previousHp);// Keep HP across levels
        hero.setHasGun(previousHasGun); // Restore gun pickup status
        hero.setPosition(new Vec2(7, -7));
        view.setWorld(world);
        view.setHero(hero);
        view.addKeyListener(new HeroController(hero));
        world.start();
    }

    public static void main(String[] args) {
        new Game();
    }
}
