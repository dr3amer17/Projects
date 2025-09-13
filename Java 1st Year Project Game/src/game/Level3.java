package game;

import city.cs.engine.BoxShape;
import city.cs.engine.Shape;
import city.cs.engine.StaticBody;
import org.jbox2d.common.Vec2;

/**
 * The Level3 class represents the third level of the game.
 */
public class Level3 extends GameWorld {
    @Override
    public void populate(Game game) {
        super.populate(game);

        //setBackgroundImage("data/background3.png");

        // Tough level
        // Platforms
        Shape tallPlatform = new BoxShape(2, 0.5f);

        StaticBody tower1 = new StaticBody(this, tallPlatform);
        tower1.setPosition(new Vec2(-15, 2));

        StaticBody tower2 = new StaticBody(this, tallPlatform);
        tower2.setPosition(new Vec2(15, 5));

        // Enemies
        Enemy enemy1 = new Enemy(this);
        enemy1.setPosition(new Vec2(-15, 3)); // on tower1
        addEnemy(enemy1);

        Enemy enemy2 = new Enemy(this);
        enemy2.setPosition(new Vec2(15, 6)); // on tower2
        addEnemy(enemy2);

        Enemy enemy3 = new Enemy(this);
        enemy3.setPosition(new Vec2(0, -10)); // ground
        addEnemy(enemy3);

        Enemy enemy4 = new Enemy(this);
        enemy4.setPosition(new Vec2(5, -10)); // ground
        addEnemy(enemy4);



        // Fast enemies
        FastEnemy fastEnemy1 = new FastEnemy(this);
        fastEnemy1.setPosition(new Vec2(-3, 5));

        FastEnemy fastEnemy2 = new FastEnemy(this);
        fastEnemy2.setPosition(new Vec2(6, -5));



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

        spawnPortal(game, new Vec2(18, -9.7f));

    }
}
