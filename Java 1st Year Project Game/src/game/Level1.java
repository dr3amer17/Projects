package game;
import city.cs.engine.*;
import org.jbox2d.common.Vec2;

/**
 * The Level1 class represents the first level of the game.
 */
public class Level1 extends GameWorld {

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

        // Platforms
        Shape platformShape = new BoxShape(4, 0.5f);
        StaticBody platform1 = new StaticBody(this, platformShape);
        platform1.setPosition(new Vec2(-10, -7));

        StaticBody platform2 = new StaticBody(this, platformShape);
        platform2.setPosition(new Vec2(6, -2));


        Enemy enemy1 = new Enemy(this);
        enemy1.setPosition(new Vec2(-10, -4)); // on platform 1
        addEnemy(enemy1);

        Enemy enemy2 = new Enemy(this);
        enemy2.setPosition(new Vec2(6, -1)); // on platform 2
        addEnemy(enemy2);

        Enemy enemy3 = new Enemy(this);
        enemy3.setPosition(new Vec2(0, -10)); // on ground
        addEnemy(enemy3);

        //spawn portal
        spawnPortal(game, new Vec2(-18, -9.8f));

        HealingPotion potion = new HealingPotion(this);
        potion.setPosition(new Vec2(16, -10));

        // Adds gun to the game
        GunPickup gun = new GunPickup(this);
        gun.setPosition(new Vec2(4.5f, -10.5f));

    }
}
