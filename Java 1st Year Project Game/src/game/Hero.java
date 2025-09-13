package game;
import city.cs.engine.*;

/**
 * The Hero class represents the player-controlled character.
 * The Hero can move, jump, take damage, heal, pick up guns, and shoot bullets.
 */
public class Hero extends Walker {
    private static final Shape heroShape = new PolygonShape(
            -0.84f,-0.38f, -0.44f,-1.46f, 0.76f,-1.46f, 0.6f,0.65f, 0.2f,1.48f, -0.32f,1.38f, -0.85f,0.05f
    );

    private static final BodyImage heroImage = new BodyImage("data/hero.png", 3f);
    private static final BodyImage heroImage1 = new BodyImage("data/hero1.png", 3f);



    private int hp = 100;
    private Game game;
    private boolean hasGun = false;
    private int facingDirection = 1;

    public int getFacingDirection() {
        return facingDirection;
    }



    public void setFacingDirection(int direction) {
        this.facingDirection = direction;
    }
    public static BodyImage getRightImage() {
        return heroImage;
    }

    public static BodyImage getLeftImage() {
        return heroImage1;
    }


    public boolean hasGun() {
        return hasGun;
    }
    public void setHasGun(boolean hasGun) {
        this.hasGun = hasGun;
    }

    public Hero(World world) {
        super(world, heroShape);
        addImage(heroImage);
    }

    public void setGame(Game game) {
        this.game = game;
    }

    public Game getGame()
    {
        return game;
    }

    public int getHp() {
        return hp;
    }
    // Increase hp method
    public void decreaseHp(int amount) {
        hp -= amount;
        if (hp <= 0) {
            System.out.println("Hero has died!");
            new GameOverScreen(); // show game over screen
            this.destroy();
        }
    }
    // decrease hp method
    public void increaseHp(int amount) {
        hp += amount;
        if (hp > 100) {
            hp = 100;
        }
    }

    public void setHp(int hp) {
        this.hp = hp;
    }
}
