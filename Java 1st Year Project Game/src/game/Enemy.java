package game;
import city.cs.engine.*;
import javax.swing.Timer;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Where enemy is created. Changes image based on direction.
 */
public class Enemy extends Walker
{
    private static final Shape enemyShape = new PolygonShape(
            -0.14f,1.37f, -0.94f,-0.61f, -0.45f,-1.46f, 0.54f,-1.48f, 0.86f,-0.64f, 0.41f,1.37f);
    // 2 different images
    private static final BodyImage rightImage = new BodyImage("data/cyberg.png", 3f);
    private static final BodyImage leftImage = new BodyImage("data/cyberg1.png", 3f);

    private float speed = 2;
    private Timer movementTimer;
    //constructor
    public Enemy(World world)
    {
        super(world, enemyShape);
        addImage(rightImage);
        startWalking(speed);

        movementTimer = new Timer(3000, new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                reverseDirection();
            }
        });
        movementTimer.start();
    }
    //Image changes every 3 seconds with direction
    private void reverseDirection()
    {
        speed = -speed;
        startWalking(speed);
        updateImage(); // Update image when reversing
    }
    //Updating image method
    private void updateImage()
    {
        removeAllImages();
        if (speed > 0) {
            addImage(rightImage);
        } else {
            addImage(leftImage);
        }
    }
}
