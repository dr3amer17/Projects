package game;
import city.cs.engine.*;
import javax.swing.Timer;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
/**
 * The Bullet class represents a projectile that the Hero can shoot.
 * Bullets move horizontally, do not fall due to gravity,
 * and destroy themselves automatically after a few seconds if they don't hit anything.
 */
public class Bullet extends DynamicBody {
    private static final Shape bulletShape = new BoxShape(0.2f, 0.1f);

    /**
     * Constructor for Bullet.
     * Initializes the bullet shape, image, gravity behavior, and self-destruction timer.
     *
     * @param world The world the bullet exists in.
     */

    public Bullet(World world)
    {
        super(world, bulletShape);
        addImage(new BodyImage("data/Bullet.png", 0.5f)); // small bullet image
        setGravityScale(0); // So bullet doesn't fall

        // after 4 seconds delete bullet
        Timer timer = new Timer(4000, new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e) {
                destroy();
            }
        });
        timer.setRepeats(false);
        timer.start();
    }
}
