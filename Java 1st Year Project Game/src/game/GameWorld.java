package game;
import city.cs.engine.*;
import org.jbox2d.common.Vec2;
import java.util.ArrayList;
import java.util.List;

/**
 * The GameWorld class represents the main world where the game takes place.
 *
 * It manages:
 * - The Hero
 * - The Enemies
 * - The Portal spawning when all enemies are defeated
 */
public class GameWorld extends World {
    private Hero hero;
    protected List<Enemy> enemies = new ArrayList<>();
    protected Portal portal;

    public GameWorld() {
        super();
        hero = new Hero(this);
        hero.setPosition(new Vec2(7, -7));
        hero.addCollisionListener(new Collisions(hero));
    }

    public Hero getHero() {
        return hero;
    }

    public void populate(Game game)
    {
        // Empty: actual level design happens in Level1, Level2, Level3
    }

    //  Add enemy to list
    public void addEnemy(Enemy enemy) {
        enemies.add(enemy);
    }

    //  Remove enemy from list
    public void removeEnemy(Enemy enemy)
    {
        enemies.remove(enemy);
    }

    //  Spawn portal when ready
    public void spawnPortal(Game game, Vec2 position)
    {
        portal = new Portal(this);
        portal.setPosition(position);
        portal.addCollisionListener(new PortalListener(game));

    }
}
