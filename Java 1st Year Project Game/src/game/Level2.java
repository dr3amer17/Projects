package game;
import city.cs.engine.*;
import org.jbox2d.common.Vec2;

/**
 * The Level2 class represents the second level of the game.
 */
public class Level2 extends GameWorld {

    @Override
    public void populate(Game game) {
        super.populate(game);

        // Ground
        Shape groundShape = new BoxShape(30, 0.5f);
        StaticBody ground = new StaticBody(this, groundShape);
        ground.setPosition(new Vec2(0, -11.5f));

        // Invisible Left Wall
        Shape leftWallShape = new BoxShape(0.5f, 50f);
        StaticBody leftWall = new StaticBody(this, leftWallShape);
        leftWall.setPosition(new Vec2(-20.6f, 0));

        // Invisible Right Wall
        Shape rightWallShape = new BoxShape(0.5f, 50f);
        StaticBody rightWall = new StaticBody(this, rightWallShape);
        rightWall.setPosition(new Vec2(20.6f, 0));

        // plstforms
        Shape platformShape = new BoxShape(6, 0.5f);

        StaticBody step1 = new StaticBody(this, platformShape);
        step1.setPosition(new Vec2(-15, -8));

        StaticBody step2 = new StaticBody(this, platformShape);
        step2.setPosition(new Vec2(0, -5));

        StaticBody step3 = new StaticBody(this, platformShape);
        step3.setPosition(new Vec2(15, -2));

        // Enemies
        Enemy enemy1 = new Enemy(this);
        enemy1.setPosition(new Vec2(-15, -7)); // on step1
        addEnemy(enemy1);

        Enemy enemy2 = new Enemy(this);
        enemy2.setPosition(new Vec2(0, -4)); // on step2
        addEnemy(enemy2);

        Enemy enemy3 = new Enemy(this);
        enemy3.setPosition(new Vec2(15, -1)); // on step3
        addEnemy(enemy3);

        Enemy enemy4 = new Enemy(this);
        enemy4.setPosition(new Vec2(0, -10)); // ground enemy
        addEnemy(enemy4);

        spawnPortal(game, new Vec2(18, -9.7f));

        HealingPotion potion = new HealingPotion(this);
        potion.setPosition(new Vec2(16, -10));
    }
}
