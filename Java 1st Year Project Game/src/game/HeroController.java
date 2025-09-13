package game;
import org.jbox2d.common.Vec2;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
/**
 * The HeroController class listens for keyboard input to control the Hero.
 * Handles:
 * - Walking left and right
 * - Jumping
 * - Shooting bullets when a gun is picked up
 */
public class HeroController implements KeyListener
{
    public Hero hero;
    public HeroController ( Hero hero)
    {
        this.hero = hero;
    }
    public void keyTyped(KeyEvent e)
    {
    }

    @Override
    public void keyPressed(KeyEvent e) // listens for keys
    {
        int code = e.getKeyCode();
        // other key commands omitted
        if (code == KeyEvent.VK_A)
        {
            hero.setFacingDirection(-1); // make the bullets go left
            hero.startWalking(-5);
            hero.removeAllImages(); // Remove old image
            hero.addImage(Hero.getLeftImage()); // Add left-facing image

        }
        else if (code == KeyEvent.VK_D)
        {
            hero.setFacingDirection(1);
            hero.startWalking(5);
            hero.removeAllImages(); // Remove old image
            hero.addImage(Hero.getRightImage()); // Add right-facing image
        }
        else if ( code == KeyEvent.VK_SPACE)
        {
            hero.jump(13);
        }
        else if ( code == KeyEvent.VK_E)
        {
            if (hero.hasGun())
            {
                shoot();
            }
        }
    }

    @Override
    public void keyReleased(KeyEvent e)
    {
        int code = e.getKeyCode();
        if (code == KeyEvent.VK_A || code == KeyEvent.VK_D)
        {
            hero.startWalking(0); // Stop movement when key is released
        }
    }
    private void shoot() {
        Bullet bullet = new Bullet(hero.getWorld());

        // if Hero is facing right (1), place bullet 1.5 units to the right.
        //If facing left (-1), place bullet 1.5 units to the left.
        //(This prevents bullet from spawning inside the Hero’s body.)
        float bulletOffsetX = hero.getFacingDirection() > 0 ? 1.5f : -1.5f;
        //Sets bullet’s position slightly in front of the Hero horizontally (+/- 1.5 units)
        // and slightly higher vertically (+0.5 units) to match Hero’s hands (looks better).
        bullet.setPosition(new Vec2(
                hero.getPosition().x + bulletOffsetX,
                hero.getPosition().y + 0.5f // slightly higher to match hero
        ));
        // shoots with 10 velocity
        bullet.setLinearVelocity(new Vec2(10 * hero.getFacingDirection(), 0));
        bullet.addCollisionListener(new Collisions(hero));
    }


}